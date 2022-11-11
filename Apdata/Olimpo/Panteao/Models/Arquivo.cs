using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("Arquivo")]
    public class Arquivo : Base
    {
        public string? Regedit { get; set; } = "";
        public string? Ini { get; set; } = "";
        public string? Cfg { get; set; } = "";
    }
}