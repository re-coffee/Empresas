using System.Data;
using System.Data.SqlClient;

namespace ApBuild.Classes
{
    internal class Conexao
    {
        public Conexao(Arquivo arquivo)
        {
            Arquivo = arquivo;
            PopulaListaInstancias();
            PopularListaDescompassos();
        }
        public List<string> ListaInstancias { get; set; } = new List<string>();
        public List<string> ListaDescompassos { get; set; } = new List<string>();
        public string Campos { get; set; } = "";
        private Arquivo Arquivo { get; set; }

        public void PopulaListaInstancias()
        {
            foreach (var servidor in Arquivo.ServidoresBancos.Where(x => !Arquivo.Excecoes.Any(e => x.Contains(e, StringComparison.OrdinalIgnoreCase))))
            {
                using (var con = new SqlConnection($"Data Source={servidor};Trusted_Connection=True;Connect Timeout=500;"))
                {
                    try
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(ConsultaBancos(), con))
                        {
                            using (IDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    var instancia = $"Server={servidor};Database={dr[0]};Trusted_Connection=True;Connect Timeout=500";
                                    //var instancia = $"Server={servidor};Database={dr[0]};User Id=apdata;Password=apdata;";
                                    ListaInstancias.Add(instancia);
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
        }
        public void PopularListaDescompassos()
        {
            foreach (var instancia in ListaInstancias)
            {
                using (var con = new SqlConnection(instancia))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(Arquivo.Query, con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            var campos = "";
                            var descompasso = "";
                            while (dr.Read())
                            {
                                descompasso += "\n\t<tr>";
                                campos = "\t<tr>";
                                for (int i = 0; i < dr.FieldCount; i++)
                                {
                                    campos += $"\n\t\t<th>{dr.GetName(i)}</th>";
                                    descompasso += $"\n\t\t<td>{dr[i]}</td>";
                                }
                                descompasso += "\n\t</tr>";
                                campos += "\n\t</tr>";
                                if (Campos.Length == 0) Campos = campos;
                            }
                            if (descompasso.Length != 0) ListaDescompassos.Add(descompasso);
                        }
                    }
                }
            }
        }
        public string ConsultaBancos()
        {
            var query = "Select name from sys.databases where [state] = 0 ";
            foreach (var excecao in Arquivo.Excecoes)
            {
                query += $"and name not like '{excecao}' ";
            }
            query += ";";
            return query;
        }
    }
}
