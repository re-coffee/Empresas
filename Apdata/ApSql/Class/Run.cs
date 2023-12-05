using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApSql.Class
{
    internal class Run : Master
    {
        public string CurrentInstance { get; set; }
        public int CurrentInstanceCount { get; set; }
        public int CurrentCommandCount { get; set; }
        public int TotalInstancesCount { get; set; }
        public int TotalCommandsCount { get; set; }
        public int ErrorCount { get; set; }
        public Run() { }
        public async void Execute(List<string> instanceList, List<string> commandList, string conString, TextBox log)
        {
            CurrentInstanceCount = 0;
            foreach (var instance in instanceList)
            {
                var client = instance;
                try
                {
                     client = instance.Split(":", 2)[1];
                }
                catch { }
                
                CurrentInstanceCount++;
                CurrentInstance = $"({client})";

                Action action0 = () => log.AppendText($"/*   {client}   */\r\n---- Begin\r\n\r\n\r\n");
                log.Invoke(action0);
                var connectionString = "";
                try
                {
                    var sv = instance.Split(":", 2)[0];
                    var db = instance.Split(":", 2)[1];
                    connectionString =
                    conString
                                    .Replace("#Server#", sv, StringComparison.OrdinalIgnoreCase)
                                    .Replace("#DataBase#", db, StringComparison.OrdinalIgnoreCase);
                }
                catch
                {
                    Action action1 = () => log.AppendText("Invalid instance/connection string\r\n\r\n\r\n---- End\r\n\r\n\r\n\r\n");
                    log.Invoke(action1);
                    continue;
                }
                
                foreach (var command in commandList)
                {
                    var logText = "";
                    Task runCommand = Task.Run(() =>
                    {
                        logText = Log(Connection.GetDataTableTuple(connectionString, command));
                    });
                    runCommand.Wait();

                    Action action2 = () => log.AppendText(logText);
                    log.Invoke(action2);
                    CurrentCommandCount++;
                }
                Action action3 = () => log.AppendText("---- End\r\n\r\n\r\n\r\n");
                log.Invoke(action3);
                CurrentCommandCount = 0;
            }
            CurrentInstanceCount = 0;
            CurrentInstance = "";
        }

        internal string InstanceLabel()
        {
            return $"Instance: {CurrentInstanceCount} of {TotalInstancesCount} {CurrentInstance}";
        }

        internal string CommandLabel()
        {
            return $"Command : {CurrentCommandCount} of {TotalCommandsCount}";
        }

        internal string Log(Tuple<DataTable, int, string> dataTable)
        {
            if (dataTable.Item2 >= 0)
                return $"({dataTable.Item2} row(s) affected)\r\n\r\n\r\n";
            
            if (dataTable.Item1.Columns.Count == 0)
                return "No result\r\n\r\n\r\n";

            var dt = dataTable.Item1;
            var collumnText = "";
            var delimiterText = "";
            var rowsText = "";
            var errors = dataTable.Item3;

            foreach (var collumn in dt.Columns.OfType<DataColumn>().ToList())
            {
                collumnText += $"{collumn}\t";
                delimiterText += $"{string.Join("", Enumerable.Repeat("-", collumn.ToString().Length))}\t";
            }
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    rowsText += $"{row[i]}\t";
                }
                rowsText = rowsText.Trim() + Environment.NewLine;
            }
            var result = $"{collumnText.Trim()}\r\n{delimiterText.Trim()}\r\n{rowsText}";
            
            if (!string.IsNullOrEmpty(errors))
                result = errors;

            return $"{result}\r\n\r\n\r\n";
        }
    }
}
