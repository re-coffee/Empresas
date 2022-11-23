namespace ApControle.Classes
{
    internal class Atualiza
    {
        public Atualiza()
        {
            InserirControle();
        }
        public List<Controle>? Controles { get; set; } = new List<Controle>();
        public List<Servidor>? Servidores { get; set; } = new Contexto().Servidores.ToList();
        public void InserirControle()
        {
            foreach (var servidor in Servidores.Where(x => x.Instancia.Length > 0).ToList())
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
                        }
                        else
                        {
                            controleContexto.TamanhoBase = controle.TamanhoBase;
                            controleContexto.UltimoLogin = controle.UltimoLogin;
                            controleContexto.Ativo = controle.Ativo;
                        }
                        Contexto.SaveChanges();
                    }
                }
            }
                
        }
    }
}
