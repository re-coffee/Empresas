using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("Menu", Schema = "adm")]
    public class Menu : Base
    {
        public int? IdRole { get; set; } = 0;
        public string? Controller { get; set; } = "";
        public string? Action { get; set; } = "";
        [ForeignKey("IdRole")]
        public virtual Role? Role { get; set; }

    }
}
