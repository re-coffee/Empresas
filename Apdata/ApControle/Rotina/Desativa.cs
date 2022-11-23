using Microsoft.Data.SqlClient;

namespace ApControle.Classes
{
    internal class Desativa
    {
        public Desativa() { Desativar(); }
        public List<Controle> Controles { get; set; } =
            new Contexto().Controles.Where(x => x.DataFim.Value.Date <= DateTime.Now.Date && x.Ativo == true).ToList();

        private void Desativar()
        {
            foreach (var controle in Controles)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(GetStringConexao(controle)))
                    {
                        con.Open();
                        using (SqlCommand takeOffliine = new SqlCommand(TakeOffline(controle), con))
                        {
                            takeOffliine.ExecuteReader();
                        }
                        con.Close();
                    }
                }
                catch { continue; }
            }
        }

        private string TakeOffline(Controle controle)
        {
            return $"ALTER DATABASE {controle.Database.Split(':')[1]} SET OFFLINE;";
        }

        private string GetStringConexao(Controle controle)
        {
            var instanciaControle = controle.Database.Split(':')[0];
            var servidorControle = new Contexto().Servidores.Where(x => x.Instancia == instanciaControle).FirstOrDefault();

            return servidorControle.AutenticaWindows ?
                $"Server={servidorControle.Instancia};Database=master;Trusted_Connection=True;TrustServerCertificate=True;" :
                $"Server={servidorControle.Instancia};Database=master;User Id={servidorControle.Usuario};Password={servidorControle.Senha};TrustServerCertificate=True;";
        }
    }
}
