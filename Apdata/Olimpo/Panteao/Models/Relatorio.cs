﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Panteao
{
    [Table("Relatorio", Schema = "adm")]
    public class Relatorio : Base
    {
        public int? IdRole { get; set; } = 0;
        public string? View { get; set; } = "";

        [ForeignKey("IdRole")]
        public virtual Role? Role { get; set; }
    }
}
