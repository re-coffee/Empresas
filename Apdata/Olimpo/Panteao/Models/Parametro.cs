using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("Parametro", Schema = "adm")]
    public class Parametro : Base
    {
        public string? Funcao { get; set; } = "";
        public string? Valor { get; set; } = "";
    }
}