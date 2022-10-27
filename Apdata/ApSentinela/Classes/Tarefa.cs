using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ApSentinela
{
    public partial class Tarefa
    {
        public string Servidor { get; set; }
        public string Cliente { get; set; }
        public string Caminho { get; set; }
        public string NomeTarefa { get; set; }
        public DateTime? UltimaExecucao { get; set; }
        public DateTime? ProximaExecucao { get; set; }
        public string UltimoResultado { get; set; }
        public Tarefa()
        {
            Servidor = Dns.GetHostName();
        }
    }
}
