using ApSql.Class;
using System.Windows.Forms;

namespace ApSql
{
    public partial class ApSqlForm : Form
    {
        Master Master { get; set; }

        public ApSqlForm()
        {
            InitializeComponent();
            Directory.CreateDirectory(".\\Xml\\");
            File.Open(".\\Xml\\Cluster.xml", FileMode.Append).Dispose();
            File.Open(".\\Xml\\Parameter.xml", FileMode.Append).Dispose();
            Master = new Master(this, new Server(), new Query(), new Run());
        }

        private void ApSqlForm_Load(object sender, EventArgs e)
        {
            Master.Start();
            Master.Refresh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Master.UpdateCount();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            Master.Filter(filterTextBox.Text);
            Master.Refresh();
        }

        private void moveAllServerButton_Click(object sender, EventArgs e)
        {
            Master.Server.Move(databaseDataGridView.Rows);
            Master.Refresh();
        }

        private void moveSelectedServerButton_Click(object sender, EventArgs e)
        {
            Master.Server.Move(databaseDataGridView.SelectedRows);
            Master.Refresh();
        }

        private void clearInstanceListDGVButton_Click(object sender, EventArgs e)
        {
            Master.Server.Clear();
            Master.Refresh();
        }

        private void addQueryButton_Click(object sender, EventArgs e)
        {
            Master.Query.Move(queryTextBox.Text.Split(';'));
            Master.Refresh();
        }

        private void clearCommandListDGVButton_Click(object sender, EventArgs e)
        {
            Master.Query.Clear();
            Master.Refresh();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Master.BlockAll(true);
            Master.Run.Execute(Master.Server.InstanceList, Master.Query.CommandList, Master.Parameter.ConnectionString, Master.Form.logTextBox);
            Master.Refresh();
            Master.BlockAll(false);
        }

        private void clipRunButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(logTextBox.Text != "" ? logTextBox.Text : "*");
        }

        private void clusterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Master.Filter(filterTextBox.Text);
            Master.Refresh();
        }
    }
}