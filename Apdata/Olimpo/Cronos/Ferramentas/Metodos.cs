using Microsoft.Win32;
using Panteao;
using System.Diagnostics;
using System.ServiceProcess;

namespace Cronos.Ferramentas
{
    internal class Metodos : Context
    {
        public Metodos(ServiceController servicoWindows)
        {
            ServicoWindows = servicoWindows;
        }
        public Context ctx { get; set; } = new Context();
        public ServiceController ServicoWindows { get; set; }
        public int IdServidorAtual { get; set; }

        internal int? GetIdTipoServico(string nomeClasse)
        {
            return ctx.TiposServicos
                            .Where(x =>
                            x.Titulo.ToLower() == nomeClasse.ToLower())
                            .FirstOrDefault()?.Id ?? null;
        }

        internal int? GetIdCliente(string instanciaBanco)
        {
            return ctx.Clientes
                            .Where(x =>
                            x.NomeInstancia == instanciaBanco)
                            .FirstOrDefault()?.Id ?? null;
        }

        internal int? GetIdServidorBanco(string servidorBanco)
        {
            return ctx.Servidores
                            .Where(x =>
                            x.Ip == servidorBanco ||
                            x.Hostname == servidorBanco)
                            .FirstOrDefault()?.Id ?? null;
        }

        internal string? GetExe(string imagePath)
        {
            return imagePath.Substring(0, imagePath.IndexOf(".exe", StringComparison.OrdinalIgnoreCase) + 4);
        }

        internal string? GetBuild(string caminhoExecutavel)
        {
            var build = "";
            try
            {
                build =
                    FileVersionInfo.GetVersionInfo(caminhoExecutavel).FileVersion +
                    $" [{File.GetLastWriteTime(caminhoExecutavel).ToString("dd-MM-yyyy HH:mm")}]";
            }
            catch { }

            return build;
        }

        internal string GetReg(string caminho, string valor)
        {
            var reg = "";
            try
            {
                reg = RegistryKey
                .OpenRemoteBaseKey(RegistryHive.LocalMachine, ServicoWindows.MachineName, RegistryView.Registry64)
                .OpenSubKey(caminho, true)
                .GetValue(valor)
                .ToString();
            }
            catch { }
            return reg;
                
        }

        internal string GetArquivo(string caminhoPasta, string extensao, string tipo)
        {
            var arquivoFormatado = "";
            var caminhoArquivo = Directory.GetFiles(caminhoPasta).Where(x =>
                                              x.StartsWith(tipo, StringComparison.OrdinalIgnoreCase) &&
                                              x.EndsWith(extensao, StringComparison.OrdinalIgnoreCase))
                                       .FirstOrDefault();
            foreach (var linha in File.ReadAllLines(caminhoArquivo))
                arquivoFormatado += $"{linha}<br>";

            return arquivoFormatado;
        }

        internal string GetCaminhoServidor(string caminho, int idServidor)
        {
            var ip = ctx.Servidores.Where(x => x.Id == idServidor)
                .FirstOrDefault().Ip;
            return 
                $"\\\\{ip}\\{caminho.Replace(":", "$")}";
        }
    }
}
