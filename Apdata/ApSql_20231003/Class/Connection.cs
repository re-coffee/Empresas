using System.Data;
using System.Data.SqlClient;

namespace ApSql.Class
{
    internal static class Connection
    {
        internal static Tuple<DataTable, int> GetDataTableTuple(string conStr, string com)
        {
            DataTable dataTable = new DataTable();
            int recordsAffected;

            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var command = new SqlCommand(com, con))
                {
                    var result = command.ExecuteReader();
                    dataTable.Load(result);
                    recordsAffected = result.RecordsAffected;
                    result.Close();
                }
                con.Close();
            }
            return Tuple.Create(dataTable, recordsAffected);
        }
    }
}
