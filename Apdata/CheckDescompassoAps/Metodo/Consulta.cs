using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CheckDescompassoAps
{
    
    public partial class Consulta
    {
        public string ComandoSql()
        {
            var query = "if not exists (select ECV_NusBuildApServer, ECV_DssNomeInstancia, ECV_NuiPorta, ECV_DSSNomeMaquina, case when ECV_OplApServerPrincipal = 1 then 'Sim' else 'Nao' end as ServerPrincipal from InstanciasApServer where ECV_DtdFimInstancia is null) select ECV_NusBuildApServer, ECV_DssNomeInstancia, ECV_NuiPorta, ECV_DSSNomeMaquina, case when ECV_OplApServerPrincipal = 1 then 'Sim' else 'Nao' end as ServerPrincipal from t_InstanciasApServer where ECV_DtdFimInstancia is null; else select ECV_NusBuildApServer, ECV_DssNomeInstancia, ECV_NuiPorta, ECV_DSSNomeMaquina, case when ECV_OplApServerPrincipal = 1 then 'Sim' else 'Nao' end as ServerPrincipal from InstanciasApServer where ECV_DtdFimInstancia is null";
            return query;

        }
        public List<Arquivo> GerarComparativo()
        {
            BuscarBases();
            return GetInstancias();
        }
        private void BuscarBases()
        {
            foreach (var Banco in Bancos)
            {
                using (var con = new SqlConnection($"Data Source={Banco}; Integrated Security=True;"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases where name like '%C%';", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                var stringConexao = $"Server = {Banco}; Database = {dr[0]}; Trusted_Connection = True;";
                                var cliente = new Cliente(dr[0].ToString(), Banco, stringConexao);
                                ListaClientes.Add(cliente);
                            }
                        }
                    }
                }
            }
        }

        private List<Arquivo> GetInstancias()
        {
            var listaArquivos = new List<Arquivo>();
            foreach (var item in ListaClientes)
            {
                var arquivo = new Arquivo(item, item.StringConexao);
                using (SqlConnection con = new SqlConnection(item.StringConexao))
                {
                    con.Open();

                    try
                    {
                        using (SqlCommand cmd =
                        new SqlCommand(ComandoSql(), con))
                        {
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    arquivo.Instancias.Add($"{dr[0]}");
                                    arquivo.Detalhes.Add($"{dr[0]};{dr[1]};{dr[2]};{dr[3]};{dr[4]}");
                                }
                            }

                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                listaArquivos.Add(arquivo);
            }
            return listaArquivos;

        }

    }
}
