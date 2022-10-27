using System;

namespace ApSentinela
{
    class Program
    {
        static void Main(string[] args)
        {
                Tarefa task = new Tarefa();
                var lista = task.Executar();
                lista.RemoveAt(lista.Count - 1);
                Connection.InserirTask(@"Server=SRVBDGP01;Database=MonitorScripter;Trusted_Connection=True;", lista);
        }
    }
}
