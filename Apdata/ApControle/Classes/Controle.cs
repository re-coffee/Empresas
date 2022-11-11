using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApDatabaseController.Classes
{
    [Table("Controle")]
    internal class Controle
    {
        [Key]
        public int Id { get; set; }
        public string? Database { get; set; } = "";
        public string? IpServico { get; set; } = "";
        public string? PortaServico { get; set; } = "";
        public string? Destinatarios { get; set; } = "";
        public bool? Ativo { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataFim { get; set; }

    }
}
