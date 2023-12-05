using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Pattern
    {
        public string StringConnection { get; set; } = "Data Source=#DataSource#;Initial Catalog=#DataBase#;TrustServerCertificate=True;Integrated Security=true;";
        //public string StringConnection { get; set; } = "Server=#DataSource#;Database=#DataBase#;User Id=apdata;Password=apdata;TrustServerCertificate=True;";
        public string QueryDatabaseSearch { get; set; } = "select name from sys.databases where state = 0 and name like 'C%_%';";
    }
}