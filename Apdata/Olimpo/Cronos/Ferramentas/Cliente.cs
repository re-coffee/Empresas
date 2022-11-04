using Microsoft.Data.SqlClient;
using Panteao;

namespace Cronos.Ferramentas
{
    internal class Cliente
    {
        public Cliente() { Mapear(); }
        internal string Select { get; set; }
            = "select name from sys.databases where state <> '6' and name like 'C%OFI%';";

        internal List<Panteao.Cliente> Clientes { get; set; } = new List<Panteao.Cliente>();

        internal List<Servidor>? Servidores { get; set; }
            = new Context().Servidores?.Where(x => x.IdCategoria == 1).ToList();


        private void Mapear()
        {
            foreach (var servidor in Servidores.OrderBy(x => x.Id))
            {

                var stringConexao = $"Server={servidor.Hostname};Database=master;Trusted_Connection=True;";
                using (SqlConnection cnn = new SqlConnection(stringConexao))
                {
                    cnn.Open();
                    using (SqlCommand getDatabase = new SqlCommand(Select, cnn))
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
            Atualizar();
        }
        private void Atualizar()
        {
            using (var ctx = new Context())
            {
                foreach (var cliente in Clientes.OrderBy(x => x.Id))
                {
                    try
                    {
                        var cliDb = ctx.Clientes
                            .Where(x => x.Id == cliente.Id)
                            .FirstOrDefault();
                        var id = ctx.Clientes
                            .Where(x => x.Id == cliente.Id)
                            .FirstOrDefault()?.Id ?? 0;
                        if (id != 0)
                        {
                            cliDb.IdServidorBanco = cliente.IdServidorBanco;
                            cliDb.NomeInstancia = cliente.NomeInstancia;
                            cliDb.DataAtualizacao = cliente.DataAtualizacao;
                        }
                        else
                        {
                            ctx.Clientes.Add(cliente);
                        }
                        ctx.SaveChanges();
                    }
                    catch { continue; }
                }
            }
            Clientes.Clear();
        }
    }
}
