using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApControle.Classes
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
                            listaBases.Add($"{reader["name"]};{reader["state"]};{reader["data"]}");
                        }
                    }
                }
                con.Close();
                return listaBases;
            }
        }

        public List<Controle> Controles(Servidor servidor)
        {
            List<Controle> controles = new List<Controle>();
            foreach (var item in ListaBases())
            {

                var controle = new Controle();

                controle.Database = $"{servidor.Instancia}:{item.Split(';')[0]}";
                controle.Ativo = item.Split(';')[1] == "1";
                controle.DataCriacao = DateTime.Parse(item.Split(';')[2].ToString());
                try
                {
                    controle.IpServico = controle.PortaServico = "--";
                    if (controle.Ativo)
                    {
                        using (SqlConnection con = new SqlConnection(GetStringConexao(item.Split(';')[0])))
                        {
                            con.Open();
                            using (SqlCommand getIpPort = new SqlCommand(GetIpPort(), con))
                            {
                                try
                                {
                                    var reader = getIpPort.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        var controleBanco = new Contexto().Servidores
                                           .Where(x =>
                                                  x.Hostname.ToLower() ==
                                                  reader["nome"].ToString().ToLower())
                                                  .FirstOrDefault()?
                                                  .Ip ?? "";
                                        if (controleBanco != "")
                                        {

                                            controle.IpServico = controleBanco;
                                            controle.PortaServico = reader["porta"].ToString();
                                            break;
                                        }
                                    }
                                }
                                catch { }
                            }
                            con.Close();
                            con.Open();
                            using (SqlCommand getUltimoLogin = new SqlCommand(GetUltimoLogin(), con))
                            {
                                try
                                {
                                    var reader = getUltimoLogin.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        controle.UsuarioUltimoLogin = reader["UsuarioUltimoLogin"].ToString();
                                        controle.UltimoLogin = (DateTime)reader["UltimoLogin"];
                                    }
                                }
                                catch { }
                            }
                            con.Close();
                            con.Open();
                            using (SqlCommand getTamanhoBase = new SqlCommand(GetTamanhoBase(), con))
                            {
                                try
                                {
                                    var reader = getTamanhoBase.ExecuteReader();
                                    while (reader.Read())
                                    {
                                        controle.TamanhoBase = reader["TamanhoBase"].ToString();
                                    }
                                }
                                catch { }
                            }
                            con.Close();
                        }
                    }
                }
                catch { }
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
            return "select name, case state when 6 then 0 else 1 end 'state', create_date data from sys.databases where name not in ('master','tempdb','model','msdb')";
        }

        public string GetIpPort()
        {
            return
                @"IF object_id('InstanciasApServer', 'U') is not null
                    SELECT ECV_DssNomeMaquina nome, ECV_NuiPorta porta
                    FROM InstanciasApServer WHERE ECV_DtdFimInstancia is NULL
                    group by ECV_DssNomeMaquina, ECV_NuiPorta;
                  ELSE
                    SELECT ECV_DssNomeMaquina nome, ECV_NuiPorta porta
                    FROM t_InstanciasApServer WHERE ECV_DtdFimInstancia is NULL
                    group by ECV_DssNomeMaquina, ECV_NuiPorta;";
        }

        public string GetUltimoLogin()
        {
            return
                @"SELECT top 1 LOS_CdsUsuario UsuarioUltimoLogin, LOS_DtdDataHoraLogIn UltimoLogin from LOGS where LOS_DtdDataHoraLogIn is not null and LOS_CdsUsuario not in ('ap_uptime','iti','VirtualUser') order by LOS_DtdDataHoraLogIn desc";
        }
        public string GetTamanhoBase()
        {
            return
                @"SELECT cast(CAST(SUM(size) * 8. / 1024 AS DECIMAL(8,2)) as varchar) + ' MB' as TamanhoBase FROM sys.master_files WHERE database_id = DB_ID() GROUP BY database_id";
        }

    }
}
