using Panteao;
using System.ServiceProcess;

namespace Cronos.Ferramentas
{
    internal class Base
    {
        public Base() { ExecutaProcesso(); }

        internal List<Servidor>? Servidores { get; set; } = new Context().Servidores?.Where(x => x.IdCategoria > 1).OrderBy(x => x.Id).ToList();
        internal List<Servico>? Servicos { get; set; } = new List<Servico>();
        internal List<ServiceController>? ServicosWindows { get; set; } = new List<ServiceController>();

        internal void ExecutaProcesso()
        {
            foreach(var servidor in Servidores)
            {
                ServicosWindows =
                    ServiceController
                    .GetServices(servidor.Ip)
                    .Where(x => x.ServiceName.Contains(GetType().Name, StringComparison.OrdinalIgnoreCase)
                             && x.StartType != ServiceStartMode.Disabled)
                    .ToList();

                if (ServicosWindows.Count != 0)
                    PopularServicos(servidor.Id);
            }
        }

        internal virtual void PopularServicos(int idServidorAtual) { }

        internal void AtualizarContexto()
        {
            using (var ctx = new Context())
            {
                foreach (var servico in Servicos.OrderBy(x => x.Id))
                {
                    try
                    {
                        var servicoContext = ctx.Servicos
                            .Where(x =>
                                        x.IdCliente == servico.IdCliente &&
                                        x.IdServidor == servico.IdServidor &&
                                        x.IdServidorBanco == servico.IdServidorBanco &&
                                        x.Porta == servico.Porta &&
                                        x.InstanciaBanco == servico.InstanciaBanco &&
                                        x.Titulo == servico.Titulo &&
                                        x.IdTipoServico == servico.IdTipoServico)
                            .FirstOrDefault();
                        
                        var registroExiste = servicoContext?.Id ?? 0;

                        if (registroExiste == 0)
                        {
                            ctx.Servicos.Add(servico);
                        }
                        else
                        {
                            servicoContext.Caminho = servico.Caminho;
                            servicoContext.Build = servico.Build;
                            servicoContext.DataAtualizacao = servico.DataAtualizacao;
                        }

                        ctx.SaveChanges();

                    }
                    catch { continue; }

                    
                }
                Servicos.Clear();
            }            
        }
    }
}
