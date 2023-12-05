using System.Data;
using System.Data.SqlClient;

namespace ApSql.Class
{
    internal static class Connection
    {
        internal static Tuple<DataTable, int, string> GetDataTableTuple(string conStr, string com)
        {
            var dataTable = new DataTable();
            var recordsAffected = 0;
            var errors = "";
            try
            {
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
            }
            catch (SqlException err)
            {
                errors = err.Message;

            }
            catch (Exception err)
            {
                errors = err.Message + "\r\n" + err.StackTrace;
            }
            return Tuple.Create(dataTable, recordsAffected, errors);
        }
    }
}
