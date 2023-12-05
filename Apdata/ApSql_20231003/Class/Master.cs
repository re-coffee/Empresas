using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApSql.Class
{
    internal class Master
    {
        internal ApSqlForm Form;
        public Server Server;
        public Query Query;
        public Run Run;

        /* System properties */
        public Parameter Parameter { get; set; }
        public List<Cluster> ClusterList { get; set; } = new List<Cluster>();
        /* ----------------- */

        public Master() { }
        public Master(ApSqlForm form, Server server, Query query, Run run)
        {
            Form = form;
            Server = server;
            Query = query;
            Run = run;
            Start();
            Parameter = new Xml().LoadParameter();
            ClusterList = new Xml().LoadCluster();
        }
        
        internal void Start()
        {


            Form.clusterComboBox.DataSource = ClusterList.Select(x => x.Key).ToList();

            Form.databaseDataGridView.DataSource =
            ClusterList
                            .Where(x => x.Key == Form.clusterComboBox.SelectedValue)
                            .SelectMany(x => x.DatabaseList)
                            .Select(x => new { Database = x })
                            .OrderBy(x => x.Database)
                            .ToList();
        }

        internal void Refresh()
        {
            Form.instanceDataGridView.DataSource =
            Server.InstanceList
                            .Select(x => new { Instance = x })
                            .Distinct()
                            .ToList();

            Form.commandDataGridView.DataSource =
            Query.CommandList
                            .Select(x => new { Command = x })
                            .Distinct()
                            .ToList();

            Form.instanceProgressBar.Maximum = Run.TotalInstancesCount = Server.InstanceList.Distinct().Count();
            Form.commandProgressBar.Maximum = Run.TotalCommandsCount = Query.CommandList.Distinct().Count();


        }

        public void Filter(string text)
        {
            Form.databaseDataGridView.DataSource =
            ClusterList
                            .Where(x => x.Key == Form.clusterComboBox.SelectedValue)
                            .SelectMany(x => x.DatabaseList)
                            .Select(x => new { Database = x })
                            .Where(x => x.Database.Contains(text, StringComparison.OrdinalIgnoreCase))
                            .OrderBy(x => x.Database)
                            .ToList();
        }

        internal void LoadMainCluster()
        {
            var databaseInstanceList = new List<string>();
            foreach (var item in Parameter.DatabaseList)
            {
                var tuple =
                Connection.GetDataTableTuple(
                                Parameter.ConnectionString
                                .Replace("#Server#", item, StringComparison.OrdinalIgnoreCase)
                                .Replace("#Database#", "Master", StringComparison.OrdinalIgnoreCase), Parameter.SelectDatabase);

                databaseInstanceList.AddRange(DataTableToList(item, tuple.Item1));
            }

            new Xml().SaveCluster(ClusterList);
        }


        internal void UpdateCount()
        {
            Form.instanceCountLabel.Text = Run.InstanceLabel();
            Form.instanceProgressBar.Value = Run.CurrentInstanceCount;

            Form.commandCountLabel.Text = Run.CommandLabel();
            Form.commandProgressBar.Value = Run.CurrentCommandCount;
        }

        internal void BlockAll(bool yesNo)
        {
            Form.queryTabPage.Enabled = Form.serverTabPage.Enabled = Form.runButton.Enabled = Form.clipRunButton.Enabled = !yesNo;

        }

        private List<string> DataTableToList(string server, DataTable dataTable)
        {
            var dataTableList = new List<string>();
            foreach (DataRow item in dataTable.Rows)
            {
                dataTableList.Add($"{server}:{item[0]}".Trim());
            }

            return dataTableList.Distinct().ToList();
        }
        
    }
}
