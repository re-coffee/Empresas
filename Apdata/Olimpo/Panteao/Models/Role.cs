using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("Role", Schema = "adm")]
    public class Role : Base
    {
        public string? Sigla { get; set; } = "";
        public virtual ICollection<Menu>? Menus { get; set; }
    }
}
