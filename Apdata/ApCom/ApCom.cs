using ApCom.Class;
using Class;
using System.Data;
using System.Data.SqlClient;

namespace ApCom
{
    public partial class ApCom : Form
    {
        public App App = new App(new Pattern());
        public Execute Run { get; set; }

        public ApCom()
        {
            InitializeComponent();
            App.QueryOverviewList = App.ResultQueryList;
            App.DatabaseOverviewList = App.ResultServerList;
        }

        //Events
        private void ApCom_Load(object sender, EventArgs e)
        {
            tbQueryForDatabases.Text = App.Pattern.QueryDatabaseSearch;
        
        }
        private void btAddServer_Click(object sender, EventArgs e)
        {
            foreach (var item in tbServerInstance.Text
                                        .Split(';')
                                        .Where(x => !string.IsNullOrEmpty(x) &&
                                        !App.ServerList.Contains(x)))
            {
                App.ServerList.Add(item.Trim());
            }
            tbServerInstance.Text = null;
            dgServersAndDatabases.DataSource = App.ServerList.Select(x => new { Instance = x }).ToList();
            if (App.ServerList.Count > 0)
                btProcessList.Enabled = true;

        }
        private void btProcessList_Click(object sender, EventArgs e)
        {
            App.InstanceList.Clear();
            gbServerInstance.Enabled = btProcessList.Enabled = false;
            pbLoadServer.Maximum = App.ServerList.Count;
            pbLoadServer.Value = 0;
            dgServersAndDatabases.DataSource = null;
            foreach (var item in App.ServerList)
            {

                try
                {
                    var stringCon = App.Pattern.StringConnection.Replace("#DataSource#", item).Replace("#DataBase#", "master").Trim();
                    var con = new SqlConnection(stringCon);
                    con.Open();

                    var reader = new SqlCommand(App.Pattern.QueryDatabaseSearch, con).ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            App.InstanceList.Add($"{item}:{reader.GetString(0)}");
                            dgServersAndDatabases.DataSource = App.InstanceList
                                                                  .Select(x => new { Database = x })
                                                                  .ToList();
                        }
                    }
                    reader.Close();
                    con.Close();
                }
                catch { }
                pbLoadServer.Value++;
            }
            if (App.InstanceList.Count == 0)
                Restart();
            else
                btMoveSelectedDatabase.Enabled = btMoveAllDatabase.Enabled = btClearResultServer.Enabled = true;


        }
        private void btMoveSelectedDatabase_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dgServersAndDatabases.SelectedRows)
            {
                var value = (string)dgServersAndDatabases.Rows[item.Index].Cells[0].Value;
                if (!App.ResultServerList.Contains(value))
                    App.ResultServerList.Add(value);
            }
            dgResultServer.DataSource = App.ResultServerList
                                           .Select(x => new { Database = x })
                                           .ToList();
            btClearResultServer.Enabled = true;

        }
        private void btMoveAllDatabase_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dgServersAndDatabases.Rows)
            {
                var value = (string)dgServersAndDatabases.Rows[item.Index].Cells[0].Value;
                if (!App.ResultServerList.Contains(value))
                    App.ResultServerList.Add(value);
            }
            dgResultServer.DataSource = App.ResultServerList
                                           .Select(x => new { Database = x })
                                           .ToList();
        }
        private void btClearServer_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void btClearResultServer_Click(object sender, EventArgs e)
        {
            App.ResultServerList.Clear();
            dgResultServer.DataSource = null;
        }

        private void btAddQuery_Click(object sender, EventArgs e)
        {
            var queries = tbQueries.Text.Split(";")
                                        .Distinct()
                                        .Select(x => x.Trim())
                                        .Where(x => !string.IsNullOrEmpty(x) && !App.ResultQueryList.Contains(x));
            tbQueries.Text = "";
            foreach (var item in queries)
            {
                App.ResultQueryList.Add(item);

            }
            dgResultQuery.DataSource = App.ResultQueryList
                                          .Select(x => new { Query = x })
                                          .ToList();
        }
        private void btClearResultQuery_Click(object sender, EventArgs e)
        {
            dgResultQuery.DataSource = null;
            App.ResultQueryList.Clear();
        }

        private void tcApCom_Click(object sender, EventArgs e)
        {
            dgDatabaseOverview.DataSource = App.ResultServerList
                                               .Select(x => new { Instance = x })
                                               .ToList();
            dgQueryOverview.DataSource = App.ResultQueryList
                                            .Select(x => new { Query = x })
                                            .ToList();

            lblDatabaseValue.Text = App.ResultServerList.Count.ToString();
            lblQueryValue.Text = App.ResultQueryList.Count.ToString();
            lblRunValue.Text = (App.ResultServerList.Count * App.ResultQueryList.Count).ToString();


        }
        private void btExecute_Click(object sender, EventArgs e)
        {
            Run = new Execute(App);
            Run.ResetCount();
            tbOutput.Text = "";
            Run.Cronometer.Restart();
            tmrCronometer.Start();
            Run.Cronometer.Start();
            Execute();
            Run.Cronometer.Start();
            tmrCronometer.Stop();
        }
        private void tmrCronometer_Tick(object sender, EventArgs e)
        {
            lblRuntime.Text = Run.Cronometer.Elapsed.ToString("hh\\:mm\\:ss");
        }

        //Methods
        void Restart()
        {
            gbServerInstance.Enabled = btProcessList.Enabled = true;
            dgResultServer.DataSource = dgServersAndDatabases.DataSource = null;
            btMoveSelectedDatabase.Enabled = btMoveAllDatabase.Enabled = btClearResultServer.Enabled = false;
            App.ServerList.Clear();
            App.InstanceList.Clear();
            App.ResultServerList.Clear();
            pbLoadServer.Value = 0;
            pbLoadServer.Invalidate();
        }

        void Execute()
        {
            foreach (var item in Run.App.ResultServerList)
            {
                var database = item.Split(":", 2)[1];
                var outputResult = $"<{database}>\r\n\r\n";

                var con = App.Pattern.StringConnection
                                     .Replace("#DataSource#", item.Split(':')[0])
                                     .Replace("#DataBase#", item.Split(':')[1])
                                     .Trim();

                using (SqlConnection cn = new SqlConnection(con))
                {
                    foreach (var command in Run.App.ResultQueryList)
                    {
                        using (SqlCommand cmd = new SqlCommand(command, cn))
                        {
                            try { cn.Open(); }
                            catch (SqlException msg)
                            {
                                outputResult += msg.Message;
                                CountRuns(false);
                            }


                            if (command.StartsWith("Delete", StringComparison.OrdinalIgnoreCase) ||
                               command.StartsWith("Update", StringComparison.OrdinalIgnoreCase) ||
                               command.StartsWith("Insert", StringComparison.OrdinalIgnoreCase))
                            {
                                try
                                {
                                    outputResult += $"({cmd.ExecuteNonQuery()} row(s) affected)";
                                    CountRuns(true);
                                }
                                catch (SqlException msg)
                                {
                                    outputResult = msg.Message;
                                    Run.ErrorCount++;
                                    lblErrorValue.Text = Run.ErrorCount.ToString();
                                    CountRuns(false);
                                }
                            }
                            else
                            {
                                var dataTable = new DataTable();
                                try
                                {
                                    dataTable.Load(cmd.ExecuteReader());
                                    CountRuns(true);
                                }
                                catch (SqlException msg)
                                {
                                    outputResult += msg.Message;
                                    CountRuns(false);
                                }

                                outputResult += GetResultTable(dataTable);
                            }
                            cn.Close();
                        }
                    }
                }
                tbOutput.Text += outputResult + $"</{database}>\r\n\r\n\r\n\r\n";
            }
        }
        void CountRuns(bool successOrError)
        {
            if (successOrError)
            {
                Run.SuccessCount++;
                lblSuccessValue.Text = Run.SuccessCount.ToString();
                return;
            }
            Run.ErrorCount++;
            lblErrorValue.Text = Run.ErrorCount.ToString();
        }
        string GetResultTable(DataTable dataTable)
        {
            var collumnText = "";
            var delimiterText = "";
            var rowsText = "";
            foreach (var collumn in dataTable.Columns.OfType<DataColumn>().ToList())
            {
                collumnText += $"\t{collumn}";
                delimiterText += $"\t{string.Join("", Enumerable.Repeat("-", collumn.ToString().Length))}";
            }

            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    rowsText += $"\t{row[i]}";
                }
                rowsText += Environment.NewLine;
            }
            return $"{collumnText}\r\n{delimiterText}\r\n{rowsText}\r\n\r\n";
        }

        private void btSetQueryForDatabases_Click(object sender, EventArgs e)
        {
            App.Pattern.QueryDatabaseSearch = tbQueryForDatabases.Text;
        }
    }
}