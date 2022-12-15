using Panteao;
using Microsoft.Data.SqlClient;

namespace Cronos.Classes
{
    internal class Cliente
    {
        public Cliente()
        {
            PopularClientes();
            AtualizarContexto();
        }
        internal List<Panteao.Cliente> Clientes { get; set; } = new List<Panteao.Cliente>();
        internal List<Servidor>? Servidores { get; set; } = new Context().Servidores?.Where(x => x.IdCategoria == 1).ToList();
        internal string SelectDatabases { get; set; } = "select name from sys.databases where state <> '6' and name like 'C%OFI%';";

        private void PopularClientes()
        {
            foreach (var servidor in Servidores.OrderBy(x => x.Id))
            {
                var stringConexao = $"Server={servidor.Hostname};Database=master;Trusted_Connection=True;";
                using (SqlConnection cnn = new SqlConnection(stringConexao))
                {
                    cnn.Open();
                    using (SqlCommand getDatabase = new SqlCommand(SelectDatabases, cnn))
                    {
                        using (SqlDataReader reader = getDatabase.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Panteao.Cliente cli = new Panteao.Cliente();
                                cli.IdServidorBanco = servidor.Id;
                                cli.NomeInstancia = reader["name"].ToString();
                                try
                                {
                                    cli.Id = int.Parse(reader["name"].ToString().Substring(1, 3));
                                }
                                catch { }
                                Clientes.Add(cli);
                            }
                        }
                    }
                    cnn.Close();
                }
            }
        }

        private void AtualizarContexto()
        {
            using (var ctx = new Context())
            {
                foreach (var cliente in Clientes.OrderBy(x => x.Id))
                {
                    try
                    {
                        var cliDb = ctx.Clientes
                                       .Where(x =>
                                              x.Id == cliente.Id)
                                       .FirstOrDefault();

                        if (cliDb is null)
                            ctx.Clientes.Add(cliente);
                        else {
                            cliDb.IdServidorBanco = cliente.IdServidorBanco;
                            cliDb.NomeInstancia = cliente.NomeInstancia;
                            cliDb.DataAtualizacao = cliente.DataAtualizacao; }

                        ctx.SaveChanges();}
                    catch { continue; } 
                } 
            }
            Clientes.Clear();
        }
    }
}
