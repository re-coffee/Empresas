using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApBuild.Classes
{
    internal class Arquivo
    {
        public Arquivo(string arquivo)
        {
            CaminhoArquivoParametros += arquivo;
            ProcessaArquivo();
        }
        public string CaminhoArquivoParametros { get; set; } = AppDomain.CurrentDomain.BaseDirectory.Replace('/', '\\');

        /*Parametros arquivo*/
        public List<string> ServidoresBancos { get; set; } = new List<string>();
        public List<string> Excecoes { get; set; } = new List<string>();
        public string CaminhoSaidaHtml { get; set; }
        public string CaminhoCss { get; set; }
        public string CaminhoQuery { get; set; }
        public string Query { get; set; }

        public void ProcessaArquivo()
        {
            var LinhasParametros = File.ReadAllLines(CaminhoArquivoParametros).ToList();
            CaminhoSaidaHtml = LinhasParametros.Where(x => x.StartsWith("Saida", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().ToString().Split("=")[1].Trim();
            CaminhoCss = LinhasParametros.Where(x => x.StartsWith("Css", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().ToString().Split("=")[1].Trim();
            ServidoresBancos = LinhasParametros.Where(x => x.StartsWith("Servidores", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().ToString().Split("=")[1].Split(";").Select(x => x.Trim()).Where(x => x != "").ToList();
            CaminhoQuery = LinhasParametros.Where(x => x.StartsWith("Query", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().ToString().Split("=")[1].Trim();
            Query = File.ReadAllText(CaminhoQuery);
            try
            {
                Excecoes = LinhasParametros.Where(x => x.StartsWith("Excecoes", StringComparison.OrdinalIgnoreCase)).FirstOrDefault().ToString().Split("=")[1].Split(";").Select(x => x.Trim()).Where(x => x != "").ToList();
            }
            catch { }
        }
    }
}