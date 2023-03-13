using Microsoft.Data.SqlClient;
using System.Data;

namespace ApQuery.Class
{
    internal class Connection
    {
        public Connection(Action action)
        {
            Action = action;
        }
        public Action Action { get; set; }
        public List<string> ConnectionStrings { get; set; } = new List<string>();

        public Action Go()
        {
            GetResult();
            return Action;
        }
        public void GetResult()
        {
            foreach (var server in Action.Conf["Server"].Split(';').Select(x => x.Trim()))
            {
                try
                {
                    var result = CallSql(Action.Conf["Instance"].Replace("#Server#", server).Replace("#Database#", "master"),
                                         File.ReadAllText(Action.Conf["Database"]));
                    for (int i = 0; i < result.Rows.Count; i++)
                        ConnectionStrings.Add(Action.Conf["Instance"].Replace("#Server#", server).Replace("#Database#", result.Rows[i][0].ToString()));
                }
                catch { continue; }
            }


            foreach (var conn in ConnectionStrings)
            {
                try
                {
                    InstanceValues(CallSql(conn, Action.Query));
                }
                catch { continue; }
            }
        }

        public DataTable CallSql(string connectionString, string command)
        {
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                dt.Load(new SqlCommand(command, conn).ExecuteReader());
                conn.Close();
            }
            return dt;
        }
        public void InstanceValues(DataTable data)
        {
            var col = "\t<tr class=\"header\">\n";
            var block = "";

            for (int i = 0; i < data.Columns.Count; i++)
                col += "\t\t<th>" + data.Columns[i].ColumnName + "</th>\n";
            col += "\t</tr>\n";

            if (Action.Fields is null) Action.Fields = col;

            for (int i = 0; i < data.Rows.Count; i++)
            {
                block += "\t<tr>\n";
                for (int j = 0; j < data.Columns.Count; j++)
                    block += $"\t\t<td>{data.Rows[i][j]}</td>\n";
                block += "\t</tr>\n";
            }
            Action.Values.Add(block);
        }
    }
}
