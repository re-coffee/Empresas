using Panteao;

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

                try
                {

                }
                catch { }
                try
                {

                }
                catch { }

                var caminhoExecutavel = "";


                srv.Titulo = scService.ServiceName;
                srv.IdServidor = IdServidor;
            }
            AtualizarContexto();
        }
    }
}
