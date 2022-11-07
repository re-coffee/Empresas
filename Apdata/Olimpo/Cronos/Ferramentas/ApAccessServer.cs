using Panteao;

namespace Cronos.Ferramentas
{
    internal class ApAccessServer : Base
    {
        internal override void PopularServicos(int idServidorAtual)
        {
            foreach (var servicoWindows in ServicosWindows)
            {
                var srv = new Servico();
                srv.IdTipoServico = 1;
                srv.Titulo = servicoWindows.ServiceName;
                srv.IdServidor = idServidorAtual;







            }
        }
    }
}
