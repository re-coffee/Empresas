using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("RoleMenu", Schema = "adm")]
    public class RoleMenu : Base
    {
        public int? IdRole { get; set; } = 0;
        public int? IdMenu { get; set; } = 0;
        [ForeignKey("IdRole")]
        public virtual Role? Role { get; set; }


        [ForeignKey("IdMenu")]
        public virtual Menu? Menu { get; set; }
    }
}
