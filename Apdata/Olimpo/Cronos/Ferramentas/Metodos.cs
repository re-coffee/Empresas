using Microsoft.Win32;
using Panteao;
using System.Diagnostics;
using System.ServiceProcess;

namespace Cronos.Ferramentas
{
    internal class Metodos : Context
    {
        public Metodos(string maquina, ServiceController servicoWindows)
        {
            Maquina = maquina;
            ServicoWindows = servicoWindows;
        }
        public Context ctx { get; set; } = new Context();
        public string Maquina { get; set; }
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

        internal string? GetExe(string caminho)
        {
            return caminho.Substring(0, caminho.IndexOf(".exe") + 4);
        }

        internal string? GetBuild(string caminhoExecutavel)
        {
            return 
                FileVersionInfo.GetVersionInfo(caminhoExecutavel) + 
                $" [{File.GetLastWriteTime(caminhoExecutavel).ToString("dd-MM-yyyy HH:mm")}]";
        }

        internal string GetReg(string caminho, string valor)
        {
            return
                RegistryKey
                .OpenRemoteBaseKey(RegistryHive.LocalMachine, Maquina, RegistryView.Registry64)
                .OpenSubKey(caminho, true)
                .GetValue(valor)
                .ToString();
        }
    }
}
