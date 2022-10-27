using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("Usuario", Schema = "adm")]
    public class Usuario : Base
    {
        public int? IdRole { get; set; }
        [Display(Name = "Usuário")]
        [Required(ErrorMessage = "Campo 'Usuário' é obrigatório")]
        [Column("Usuario")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Campo 'Senha' é obrigatório")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [ForeignKey("IdRole")]
        public virtual Role? Role { get; set; }
    }
}
