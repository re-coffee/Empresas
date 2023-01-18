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
            //Connection.InserirTask(@"Server=SRVDVGP01\DEVITI;Database=MonitorScripter;Trusted_Connection=True;", lista);
            Connection.InserirTask(args[0], lista);
        }
    }
}
