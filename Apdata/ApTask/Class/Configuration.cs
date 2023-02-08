using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApTask
{
    [Table("Configuration")]
    public class Configuration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Parameter { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
