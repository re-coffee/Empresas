using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApSql.Class
{
    internal class Run : Master
    {
        public int CurrentInstanceCount { get; set; }
        public int CurrentCommandCount { get; set; }
        public int TotalInstancesCount { get; set; }
        public int TotalCommandsCount { get; set; }
        public int ErrorCount { get; set; }
        public Run() { }
        public void Execute(List<string> instanceList, List<string> commandList, string conString, TextBox log)
        {
            MessageBox.Show(conString);
            MessageBox.Show(conString.Replace("#Database#", "Oi",StringComparison.OrdinalIgnoreCase));
            MessageBox.Show(conString.Replace("#Database#", "relou", StringComparison.OrdinalIgnoreCase));
            MessageBox.Show(conString);
            log.AppendText("asdf");
            







        }

        internal string InstanceLabel()
        {
            return $"Instance: {CurrentInstanceCount} of {TotalInstancesCount}";
        }

        internal string CommandLabel()
        {
            return $"Command : {CurrentCommandCount} of {TotalCommandsCount}";
        }
    }
}
