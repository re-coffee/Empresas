using Microsoft.Win32;
using Panteao;
using System.Diagnostics;

namespace Cronos.Ferramentas
{
    internal class ApServer : Base
    {
        internal override Servico InstanciarClasse(Metodos metodos, int idServidorAtual)
        {
            /*Caminhos regedit*/
            var regApdata = $@"SOFTWARE\Apdata\{metodos.ServicoWindows.ServiceName}\";
            var regPorta = $@"{regApdata}Visible Applications Servers\Self\TCP_IP Settings";
            var regDatabase = $@"{regApdata}DataBase";
            var regExe = $@"SYSTEM\CurrentControlSet\Services\{metodos.ServicoWindows.ServiceName}";

            /*Database*/
            var stringConexaoBanco = metodos.GetReg(regDatabase, "ServerName");
            var servidorBanco = stringConexaoBanco.Split(':')[0].Split(',')[0];

            /*Variaveis para instancia*/
            var idServidorBanco = metodos.GetIdServidorBanco(servidorBanco);
            var idTipoServico = metodos.GetIdTipoServico(GetType().Name);
            var caminho = metodos.GetExe(metodos.GetReg(regExe, "ImagePath"));
            var porta = int.Parse(metodos.GetReg(regPorta, "Server Port"));
            var build = metodos.GetBuild(caminho);
            var instanciaBanco = stringConexaoBanco.Split(':')[1];
            var idCliente = metodos.GetIdCliente(instanciaBanco);

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
