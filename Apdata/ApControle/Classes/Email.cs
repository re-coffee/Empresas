using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApDatabaseController.Classes
{
    internal class Email
    {
        public Email(Controle controle)
        {
            ServidorSmtp = GetSmtp().Split(':')[0];
            PortaSmtp = GetSmtp().Split(':')[1];
            Controle = controle;
        }
        public Controle Controle { get; set; }
        public string ServidorSmtp { get; set; }
        public string PortaSmtp { get; set; }

        public static string GetSmtp()
        {
            return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build()
                    .GetConnectionString("Smtp");
        }



    }
}
