using Microsoft.EntityFrameworkCore;

namespace ApControle.Classes
{
    internal class Dispara
    {
        public Dispara() { DispararLista(); }
        public List<Controle> Controles { get; set; } =
            new Contexto()
            .Controles
            .Include(x => x.Emails)
            .Where(x => x.DataFim.HasValue &&
                        x.DataFim.Value.Date > DateTime.Today.Date &&
                        x.Destinatarios.Length > 0 &&
                        x.Destinatarios != "--" &&
                        x.Ativo == true)
            .ToList();
        public void DispararLista()
        {
            foreach(var controle in Controles)
            {
                var disparoHoje = (new Contexto()
                        .Emails
                        .Where(x => 
                               x.IdControle == controle.Id &&
                               x.DataEnvio.Date == DateTime.Today.Date)
                        .FirstOrDefault()?
                        .Id ?? 0) != 0;

                if((controle.DataFim.Value - DateTime.Today).TotalDays <= 7 && !disparoHoje)
                    new Email(controle).Disparar();
            }
        }
    }
}
