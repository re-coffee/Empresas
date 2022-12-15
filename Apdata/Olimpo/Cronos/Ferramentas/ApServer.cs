using Panteao;

namespace Cronos.Ferramentas
{
    internal class ApServer : Base
    {
        internal override Servico InstanciarClasse(Metodos metodos, int idServidorAtual)
        {
            //Caminhos regedit
            var regPrincipal = $@"SOFTWARE\Apdata\{metodos.ServicoWindows.ServiceName}\";
            var regDatabase = $@"{regPrincipal}DataBase";
            var regPorta = $@"{regPrincipal}Visible Applications Servers\Self\TCP_IP Settings";
            var regImagePath = $@"SYSTEM\CurrentControlSet\Services\{metodos.ServicoWindows.ServiceName}";

            //Retornos regedit
            var instanciaBanco = metodos.GetReg(regDatabase, "ServerName");
            var idCliente = 0;
            try
            {
                idCliente = (int)metodos.GetIdCliente(instanciaBanco.Split(":")[1]);
            }
            catch { }
            
            var idServidorBanco = metodos.GetIdServidorBanco(instanciaBanco.Split(':')[0].Split(',')[0]);
            var imagePath = metodos.GetReg(regImagePath, "ImagePath");
            var executavel = metodos.GetExe(imagePath);
            var idTipoServico = metodos.GetIdTipoServico(GetType().Name);
            var caminho = metodos.GetCaminhoServidor(executavel, idServidorAtual);
            var porta = int.Parse(metodos.GetReg(regPorta, "Server Port"));
            var build = metodos.GetBuild(caminho);


            return
                new Servico
                    (idCliente: idCliente,
                    idServidor: idServidorAtual,
                    idServidorBanco: idServidorBanco,
                    idArquivo: null,
                    idTipoServico: idTipoServico,
                    caminho: caminho,
                    porta: porta,
                    build: build,
                    instanciaBanco: instanciaBanco);
        }
    }
}
