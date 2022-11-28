using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApCleanse.Class
{
    internal class Base
    {
        internal string DiretorioApp { get; set; } = AppDomain.CurrentDomain.BaseDirectory.Replace('/', '\\');
        /*Parametros*/
        internal List<string> DiretoriosVar { get; set; } = new List<string>();
        internal List<string> Servidores { get; set; } = new List<string>();
        internal List<string> Extensoes { get; set; } = new List<string>();
        internal List<string> Excecoes { get; set; } = new List<string>();
        internal string Diretorio { get; set; } = "\\\\#SERVIDOR#\\#DISCO#$";
        internal string Disco { get; set; } = "D";

        /*Processamento*/
        internal List<string> Clientes { get; set; } = new List<string>();
        internal List<string> Diretorios { get; set; } = new List<string>();
        internal List<string> Arquivos { get; set; } = new List<string>();
        internal List<string> Logs { get; set; } = new List<string>();

        /*Contadores*/
        internal Stopwatch Timer { get; set; } = new Stopwatch();
        internal double TotalGigabytes { get; set; } = 0;
        internal int TotalRegistros { get; set; } = 0;
        internal double ParcialGigabytes { get; set; } = 0;
        internal int ParcialRegistros { get; set; } = 0;
    }
}
