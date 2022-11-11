using ApDatabaseController.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApDatabaseController.Rotina
{
    internal class VerificaServidores
    {
        public VerificaServidores()
        {
            InsereControle();
        }
        public List<Controle>? Controles { get; set; } = new List<Controle>();
        public List<Servidor>? Servidores { get; set; } = new Contexto().Servidores.ToList();
        public void InsereControle()
        {
            foreach (var servidor in Servidores)
            {
                foreach (var controle in servidor.Controles(servidor))
                {
                    using (Contexto Contexto = new Contexto())
                    {
                        var controleContexto = Contexto.Controles
                            .Where(x =>
                                   x.Database == controle.Database)
                            .FirstOrDefault();

                        if ((controleContexto?.Id ?? 0) == 0)
                        {
                            Contexto.Controles.Add(controle);
                            Contexto.SaveChanges();
                        }
                    }
                }
            }
                
        }
    }
}
