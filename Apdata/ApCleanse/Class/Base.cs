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
        internal string Titulo { get; set; } = "ExclusaoArquivos";
        internal string Diretorio { get; set; } = "\\\\#SERVIDOR#\\#DISCO#$";
        internal string Disco { get; set; } = "D";
        internal string ArquivoLog { get; set; }

        /*Processamento*/
        internal List<string> Clientes { get; set; } = new List<string>();
        internal List<string> Diretorios { get; set; } = new List<string>();
        internal List<string> Arquivos { get; set; } = new List<string>();

        /*Contadores*/
        internal Stopwatch Timer { get; set; } = new Stopwatch();
        internal int ContadorDiretorios { get; set; } = 0;
        internal double ContadorGigabytes { get; set; } = 0;
        internal int ContadorRegistros { get; set; } = 0;
    }
}
