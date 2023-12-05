using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class App
    {
        public App()
        {

        }
        public App(Pattern pattern) { Pattern = pattern; }

        public List<string> ServerList = new List<string>();
        public List<string> InstanceList = new List<string>();
        public List<string> ResultServerList = new List<string>();
        public List<string> ResultQueryList = new List<string>();
        public List<string> DatabaseOverviewList = new List<string>();
        public List<string> QueryOverviewList = new List<string>();

        public Pattern Pattern = new Pattern();


    }
}
