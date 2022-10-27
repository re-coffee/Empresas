using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("Servidor")]
    public class Servidor : Base
    {
        public int? IdCategoria { get; set; }
        public string? Hostname { get; set; } = "";
        public string? Ip { get; set; } = "";

        [ForeignKey("IdCategoria")]
        public virtual Categoria? Categoria { get; set; }

        public virtual ICollection<Servico>? Servicos { get; set; }
        public virtual ICollection<Servico>? ServicosBanco { get; set; }

    }
}
