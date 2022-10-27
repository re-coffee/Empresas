using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("TipoServico")]
    public class TipoServico : Base
    {
        public virtual ICollection<Servico>? Servicos { get; set; }
    }
}
