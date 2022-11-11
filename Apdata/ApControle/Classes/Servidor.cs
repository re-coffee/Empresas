using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApDatabaseController.Classes
{
    [Table("Servidor")]
    internal class Servidor
    {
        [Key]
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Hostname { get; set; }
        public string Instancia { get; set; }
        public bool AutenticaWindows { get; set; }
        public string? Usuario { get; set; }
        public string? Senha { get; set; }
        private List<string> ListaBases()
        {
            var listaBases = new List<string>();
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                con.Open();
                using (SqlCommand getDatabase = new SqlCommand(GetDatabase(), con))
                {
                    using (SqlDataReader reader = getDatabase.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaBases.Add($"{reader["name"]};{reader["state"]}");
                        }
                    }
                    return listaBases;

                }
                con.Close();
            }
        }

        public List<Controle> Controles(Servidor servidor)
        {
            List<Controle> controles = new List<Controle>();
            foreach(var item in ListaBases())
            {

                    var controle = new Controle();

                    controle.Database = $"{servidor.Instancia}:{item.Split(';')[0]}";
                    controle.Ativo = item.Split(';')[1] == "1";
                    try
                    {
                        using (SqlConnection con = new SqlConnection(GetStringConexao(item.Split(';')[0])))
                        {
                            con.Open();
                            using (SqlCommand getDatabase = new SqlCommand(GetIpPort(), con))
                            {
                                using (SqlDataReader reader = getDatabase.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        controle.IpServico =
                                            new Contexto().Servidores
                                            .Where(x =>
                                                   x.Hostname.ToLower() ==
                                                   reader["nome"].ToString().ToLower())
                                                   .FirstOrDefault()?
                                                   .Ip ?? "";
                                        if (controle.IpServico != "")
                                        {
                                            controle.PortaServico = reader["porta"].ToString();
                                            break;
                                        }
                                    }
                                }
                            }
                            con.Close();
                        }
                    }
                    catch { controle.IpServico = controle.PortaServico = "Offline"; }
                    finally { controles.Add(controle); }
            }
            return controles;
        }

        public string GetStringConexao(string dataBase = "master")
        {
            return AutenticaWindows ?
                $"Server={Instancia};Database={dataBase};Trusted_Connection=True;TrustServerCertificate=True;" :
                $"Server={Instancia};Database={dataBase};User Id={Usuario};Password={Senha};TrustServerCertificate=True;";
        }

        public string GetDatabase()
        {
            return "select name, case state when 6 then 0 else 1 end 'state' from sys.databases where name not in ('master','tempdb','model','msdb')";
        }

        public string GetIpPort()
        {
            return "IF object_id('InstanciasApServer', 'U') is not null SELECT ECV_DssNomeMaquina nome, ECV_NuiPorta porta FROM InstanciasApServer WHERE ECV_DtdFimInstancia is NULL group by ECV_DssNomeMaquina, ECV_NuiPorta; ELSE SELECT ECV_DssNomeMaquina nome, ECV_NuiPorta porta FROM t_InstanciasApServer WHERE ECV_DtdFimInstancia is NULL group by ECV_DssNomeMaquina, ECV_NuiPorta;";
        }
    }
}
