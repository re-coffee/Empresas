using Panteao;
using System.Text.RegularExpressions;

namespace Cronos.Ferramentas
{
    internal class ApLoadBalancerServer : Base
    {
        internal override Servico InstanciarClasse(Metodos metodos, int idServidorAtual)
        {
            /*Caminhos regedit*/
            var regExe = $@"SYSTEM\CurrentControlSet\Services\{metodos.ServicoWindows.ServiceName}";

            /*Variaveis para instancia*/
            var idTipoServico = metodos.GetIdTipoServico(GetType().Name);
            var caminho = metodos.GetExe(metodos.GetReg(regExe, "ImagePath"));
            var caminhoServidor = metodos.GetCaminhoServidor(caminho, idServidorAtual);


            var build = metodos.GetBuild(caminho);
            Regex rxInstancia = new Regex("(?i)(?<=D:\\\\)(.*)(?=\\\\Server)(?-i)");
            var instancia = rxInstancia.Matches(caminhoServidor).FirstOrDefault().Value;
            var idCliente = metodos.GetIdCliente(instancia);

            /*Incluindo arquivo*/
            Arquivo arquivo = new Arquivo();
            arquivo.Ini =
                metodos.GetArquivo(caminhoServidor.Split(GetType().Name)[0], ".ini", GetType().Name);
            Regex rxPorta = new Regex("(?i)(?<=Port=)(.*)(?=<br>)(?-i)");

            var porta = 0;
            try
            {
                porta = int.Parse(rxPorta.Matches(arquivo.Ini).FirstOrDefault().Value);
            }
            catch { }

            return
                new Servico(
                    idCliente: idCliente,
                    idServidor: idServidorAtual,
                    idServidorBanco: null,
                    idArquivo: null,
                    idTipoServico: idTipoServico,
                    caminho: caminhoServidor,
                    porta: porta,
                    build: build,
                    instanciaBanco: null,
                    arquivo: arquivo);
        }
    }
}
