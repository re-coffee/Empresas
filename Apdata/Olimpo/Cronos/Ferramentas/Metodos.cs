﻿using Microsoft.Win32;
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
            return imagePath.Substring(0, imagePath.IndexOf(".exe") + 4);
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
                .OpenRemoteBaseKey(RegistryHive.LocalMachine, ServicoWindows.MachineName, RegistryView.Registry64)
                .OpenSubKey(caminho, true)
                .GetValue(valor)
                .ToString();
        }

        internal string GetArquivo(string caminhoPasta, string extensao)
        {
            var arquivoFormatado = "";
            var caminhoArquivo = Directory.GetFiles(caminhoPasta).Where(x =>
                                              x.StartsWith("ApLoadBalancerServer_", StringComparison.OrdinalIgnoreCase) &&
                                              x.EndsWith(extensao, StringComparison.OrdinalIgnoreCase))
                                       .FirstOrDefault();

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
                arquivoFormatado += $"{linha}<br>";

            return arquivoFormatado;
        }
    }
}
