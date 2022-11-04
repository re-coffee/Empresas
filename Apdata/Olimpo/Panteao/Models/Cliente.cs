using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int? IdContrato { get; set; }
        public int? IdServidorBanco { get; set; }
        public string? NomeInstancia { get; set; } = "";
        public string? Titulo { get; set; } = "";
        public string? Descricao { get; set; } = "";
        public bool Ativo { get; set; } = true;
        public virtual DateTime DataInsercao { get; set; } = DateTime.Now;
        public virtual DateTime DataAtualizacao { get; set; } = DateTime.Now;

        [ForeignKey("IdContrato")]
        public virtual Contrato? Contrato { get; set; }


        [ForeignKey("IdServidorBanco")]
        public virtual Servidor? ServidorBanco { get; set; }
        public virtual ICollection<Servico>? Servicos { get; set; }
    }
}
