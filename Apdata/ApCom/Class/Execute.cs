using Class;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ApCom.Class
{
    public class Execute
    {
        public Execute(App app)
        {
            App = app;
            TotalServers = App.ResultServerList.Count;
            TotalQueries = App.ResultQueryList.Count;

        }
        public App App { get; set; }

        public int TotalServers { get; set; }
        public int CurrentServer { get; set; } = 0;
        public int TotalQueries { get; set; }
        public int CurrentQuery { get; set; } = 0;
        public int SuccessCount { get; set; } = 0;
        public int ErrorCount { get; set; } = 0;
        public Stopwatch Cronometer { get; set; } = new Stopwatch();
        public void ResetCount()
        {
            CurrentServer = CurrentQuery = SuccessCount = ErrorCount = 0;
        }
    }
}
