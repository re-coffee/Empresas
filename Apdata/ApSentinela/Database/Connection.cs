using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Text;

namespace ApSentinela
{
    public class Connection
    {
        public List<Tarefa> ListaTarefas { get; set; }
        public static void InserirTask(string conexao, List<Tarefa> ListaTarefas)
        {
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                SqlCommand create = new SqlCommand(CreateQuery(), connection);
                create.Connection.Open();
                create.ExecuteNonQuery();
                SqlCommand truncate = new SqlCommand($"delete MonitorScripter where servidor = '{Dns.GetHostName()}';", connection);
                truncate.ExecuteNonQuery();
                SqlCommand insert = new SqlCommand(InsertQuery(ListaTarefas), connection);
                insert.ExecuteNonQuery();
            }
 
        }
        public static string CreateQuery()
        {
            var create = "if not exists(select * from sysobjects where name = 'MonitorScripter' and xtype = 'U') Create table MonitorScripter(Servidor Varchar(15), Cliente Varchar(50), CaminhoScript Varchar(100), NomeTarefa Varchar(100), DataUltimaExecucao DateTime, DataProximaExecucao DateTime, UltimoResultado Varchar(100), DataInsercao Datetime default GetDate());";
            return create;
        }

        public static string InsertQuery(List<Tarefa> listaTarefas)
        {
            string insert = "";
            foreach (var item in listaTarefas)
            {
                insert += $"insert into MonitorScripter (servidor, cliente, caminhoscript, nometarefa, dataultimaexecucao, dataproximaexecucao, ultimoresultado) values('{item.Servidor}', '{item.Cliente}', '{item.Caminho}', '{item.NomeTarefa}', '{item.UltimaExecucao}', '{item.ProximaExecucao}', '{item.UltimoResultado}');";
            }
            return insert.Replace("'null'", "null");
        }


    }
}
