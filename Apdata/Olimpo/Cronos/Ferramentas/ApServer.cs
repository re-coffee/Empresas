using Microsoft.Win32;
using Panteao;
using System.Diagnostics;

namespace Cronos.Ferramentas
{
    internal class ApServer : Base
    {
        internal override void PopularServicos(int idServidorAtual)
        {
            foreach(var servicoWindows in ServicosWindows)
            {
                var srv = new Servico();
                var regeditApdata = $@"SOFTWARE\Apdata\{servicoWindows.ServiceName}\";
                var regeditPorta = $@"{regeditApdata}Visible Applications Servers\Self\TCP_IP Settings";
                var regeditDatabase = $@"{regeditApdata}DataBase";
                var regExe = $@"SYSTEM\CurrentControlSet\Services\{servicoWindows.ServiceName}";
                var caminhoExecutavel = "";

                srv.Titulo = servicoWindows.ServiceName;
                srv.IdServidor = idServidorAtual;
                srv.IdTipoServico = 1;

                try
                {
                    caminhoExecutavel =
                        $@"\\{servicoWindows.MachineName}\" +
                        RegistryKey
                        .OpenRemoteBaseKey(RegistryHive.LocalMachine, servicoWindows.MachineName, RegistryView.Registry64)
                        .OpenSubKey(regExe, true)
                        .GetValue("ImagePath")
                        .ToString()
                        .Replace("apserver.exe", "&&", StringComparison.OrdinalIgnoreCase)
                        .Split("&&")[0]
                        .Replace(":", "$") +
                        "ApServer.exe";
                    srv.Caminho = caminhoExecutavel;

                    var arquivo = FileVersionInfo.GetVersionInfo(caminhoExecutavel);
                    srv.Build = arquivo.FileVersion + $" [{File.GetLastWriteTime(caminhoExecutavel).ToString("dd-MM-yyyy HH:mm")}]";

                }
                catch { }

                try
                {
                    srv.Porta = (int)RegistryKey
                    .OpenRemoteBaseKey(RegistryHive.LocalMachine, servicoWindows.MachineName, RegistryView.Registry64)
                    .OpenSubKey(regeditPorta, true)
                    .GetValue("Server Port");
                }
                catch { }

                try
                {
                    srv.InstanciaBanco = RegistryKey
                    .OpenRemoteBaseKey(RegistryHive.LocalMachine, servicoWindows.MachineName, RegistryView.Registry64)
                    .OpenSubKey(regeditDatabase, true)
                    .GetValue("ServerName")
                    .ToString();
                }
                catch { }
                
                using (var ctx = new Context())
                {
                    try
                    {
                        var servidorBanco = srv.InstanciaBanco.Split(':')[0].Split(',')[0];
                        var instanciaBanco = srv.InstanciaBanco.Split(':')[1];

                        srv.IdServidorBanco = ctx.Servidores
                            .Where(x =>
                            x.Ip == servidorBanco ||
                            x.Hostname == servidorBanco)
                            .FirstOrDefault()?.Id ?? null;

                        srv.IdCliente = ctx.Clientes
                            .Where(x =>
                            x.NomeInstancia == instanciaBanco)
                            .FirstOrDefault()?.Id ?? null;
                    }
                    catch { }
                }

                if ((srv.Porta == 0 && srv.InstanciaBanco == "") ||
                    (srv.IdCliente == null && srv.IdServidorBanco == null))
                {
                    continue;
                }
                Servicos.Add(srv);

            }
            AtualizarContexto();
        }
    }
}
