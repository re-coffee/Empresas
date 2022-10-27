using System.ComponentModel.DataAnnotations;

namespace Panteao
{
    public class Base
    {
        [Key]
        public virtual int Id { get; set; }
        public string? Titulo { get; set; } = "";
        public string? Descricao { get; set; } = "";
        public virtual bool Ativo { get; set; } = true;
        public virtual DateTime DataInsercao { get; set; } = DateTime.Now;
        public virtual DateTime DataAtualizacao { get; set; } = DateTime.Now;

    }
}