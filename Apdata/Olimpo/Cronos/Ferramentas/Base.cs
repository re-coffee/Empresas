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


        /*Override*/
        internal virtual Servico InstanciarClasse(Metodos metodos, int idServidorAtual) { throw new NotImplementedException(); }


        /*Metodos*/
        /*ExecutaProcesso(): instancia os servicos do windows e chama a funcao PopularServicos()
          para cada servidor*/

        /*PopularServicos(): para cada servico do windows da lista chama a funcao InstanciarClasse()
          que sera sobrescrita pelas classes que herdam conforme o servico que se quer mapear
          Apos isso chama a funcao AtualizarContexto()*/
        
        /*InstanciarClasse(): recebe o tipo ServiceController do windows e instancia o tipo Servico()*/

        /*AtualizarContexto(): para cada item da lista de Servico() populada pelas funcoes anteriores,
          testa e insere no banco utilizando o contexto*/
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
        internal void PopularServicos(int idServidorAtual)
        {
            foreach (var servicoWindows in ServicosWindows)
            {
                try
                {
                    var metodos = new Metodos(servicoWindows);
                    var srv = InstanciarClasse(metodos, idServidorAtual);
                    if ((srv.Porta == 0 && srv.InstanciaBanco == "") ||
                    (srv.IdCliente == null && srv.IdServidorBanco == null))
                        continue;

                    Servicos.Add(srv);
                }
                catch { continue; }
            }
            AtualizarContexto();
        }
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
