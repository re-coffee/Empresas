using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("Servico")]
    [Index(nameof(IdCliente), nameof(IdServidor), nameof(Porta), IsUnique = true)]
    public class Servico : Base
    {
        public Servico() { }
        public Servico(int? idCliente, int? idServidor, int? idServidorBanco, int? idArquivo, int? idTipoServico, string? caminho, int? porta, string? build, string? instanciaBanco)
        {
            IdCliente = idCliente;
            IdServidor = idServidor;
            IdServidorBanco = idServidorBanco;
            IdArquivo = idArquivo;
            IdTipoServico = idTipoServico;
            Caminho = caminho;
            Porta = porta;
            Build = build;
            InstanciaBanco = instanciaBanco;
        }
        public Servico(int? idCliente, int? idServidor, int? idServidorBanco, int? idArquivo, int? idTipoServico, string? caminho, int? porta, string? build, string? instanciaBanco, Arquivo arquivo)
        {
            IdCliente = idCliente;
            IdServidor = idServidor;
            IdServidorBanco = idServidorBanco;
            IdArquivo = idArquivo;
            IdTipoServico = idTipoServico;
            Caminho = caminho;
            Porta = porta;
            Build = build;
            InstanciaBanco = instanciaBanco;
            Arquivo = arquivo;
        }

        public int? IdCliente { get; set; }
        public int? IdServidor { get; set; }
        public int? IdServidorBanco { get; set; }
        public int? IdArquivo { get; set; }
        public int? IdTipoServico { get; set; }
        public string? Caminho { get; set; } = "";
        public int? Porta { get; set; } = 0;
        public string? Build { get; set; } = "";
        public string? InstanciaBanco { get; set; } = "";

        [ForeignKey("IdCliente")]
        public virtual Cliente? Cliente { get; set; }


        [ForeignKey("IdServidor")]
        [InverseProperty("Servicos")]
        public virtual Servidor? Servidor { get; set; }


        [ForeignKey("IdServidorBanco")]
        [InverseProperty("ServicosBanco")]
        public virtual Servidor? ServidorBanco { get; set; }


        [ForeignKey("IdArquivo")]
        public virtual Arquivo? Arquivo { get; set; }

        [ForeignKey("IdTipoServico")]
        public virtual TipoServico? TipoServico { get; set; }
    }
}
