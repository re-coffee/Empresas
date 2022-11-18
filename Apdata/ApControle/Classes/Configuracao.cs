using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApControle.Classes
{
    [Table("Configuracao")]
    internal class Configuracao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Parametro { get; set; }
        public string Valor { get; set; }

    }
}
