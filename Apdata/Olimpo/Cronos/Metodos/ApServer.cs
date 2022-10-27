using Microsoft.Win32;
using Panteao;
using System.Diagnostics;

namespace Cronos
{
    internal class ApServer : Base
    {
        public override void Atualizar()
        {
            foreach (var scService in ScServices)
            {
                
                var srv = new Servico();
                var regExe = $@"SYSTEM\CurrentControlSet\Services\{scService.ServiceName}";
                var regPort = $@"SOFTWARE\Apdata\{scService.ServiceName}\Visible Applications Servers\Self\TCP_IP Settings";
                var regDatabase = $@"SOFTWARE\Apdata\{scService.ServiceName}\DataBase";
                var executavel = "";
                srv.Titulo = scService.ServiceName;
                srv.IdServidor = IdServidor;

                try
                {
                    executavel =
                        $@"\\{scService.MachineName}\" +
                        RegistryKey
                        .OpenRemoteBaseKey(RegistryHive.LocalMachine, scService.MachineName, RegistryView.Registry64)
                        .OpenSubKey(regExe, true)
                        .GetValue("ImagePath")
                        .ToString()
                        .Replace("apserver.exe", "&&", StringComparison.OrdinalIgnoreCase)
                        .Split("&&")[0]
                        .Replace(":", "$") +
                        "ApServer.exe";
                    srv.Caminho = executavel;

                    var arquivo = FileVersionInfo.GetVersionInfo(executavel);
                    srv.Build = arquivo.FileVersion + $" [{File.GetLastWriteTime(executavel).ToString("dd-MM-yyyy HH:mm")}]";
                }
                catch { }

                try
                {
                    srv.Porta = (int)RegistryKey
                    .OpenRemoteBaseKey(RegistryHive.LocalMachine, scService.MachineName, RegistryView.Registry64)
                    .OpenSubKey(regPort, true)
                    .GetValue("Server Port");
                }
                catch { }

                try
                {
                    srv.InstanciaBanco = RegistryKey
                    .OpenRemoteBaseKey(RegistryHive.LocalMachine, scService.MachineName, RegistryView.Registry64)
                    .OpenSubKey(regDatabase, true)
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
                            .FirstOrDefault()?.Id ?? 0;

                        srv.IdCliente = ctx.Clientes
                            .Where(x => 
                            x.NomeInstancia == instanciaBanco)
                            .FirstOrDefault()?.Id ?? 0;
                    }
                    catch { }
                }

                if((srv.Porta == 0 && srv.InstanciaBanco == "") ||
                    (srv.IdCliente == null && srv.IdServidorBanco == null))
                {
                    continue;
                }
                Servicos.Add(srv);
            }

            foreach (var servico in Servicos)
            {
                try
                {
                    using (var ctx = new Context())
                    {
                        var svcDb = ctx.Servicos
                            .Where
                            (x =>
                            x.IdCliente == servico.IdCliente &&
                            x.IdServidor == servico.IdServidor &&
                            x.IdServidorBanco == servico.IdServidorBanco &&
                            x.Porta == servico.Porta &&
                            x.InstanciaBanco == servico.InstanciaBanco &&
                            x.Titulo == servico.Titulo)
                            .FirstOrDefault();
                        
                        var objeto = svcDb?.Id ?? 0;

                        if (objeto != 0)
                        {
                            svcDb.Caminho = servico.Caminho;
                            svcDb.Build = servico.Build;
                            svcDb.DataAtualizacao = servico.DataAtualizacao;
                            
                        }
                        else
                        {
                            ctx.Servicos.Add(servico);
                        }
                        ctx.SaveChanges();
                    }

                }
                catch { ServicosAtualizados.Add(servico); continue; }

            }
            IdServidor = 0;
            Insercoes += Servicos.Count;
            Servicos.Clear();
        }
    }
}
