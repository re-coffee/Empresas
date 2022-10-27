using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.IO;
using System.Globalization;

namespace ApSentinela
{
    public partial class Tarefa
    {
        public List<Tarefa> Executar(string path = @"\APDATA\*")
        {
            // Cria o comando PowerShell a ser chamado pelo CMD
            string outPut = $"{Directory.GetCurrentDirectory()}\\Retorno.txt";
            string comando = $"PowerShell.exe -command \"Get-ScheduledTask -TaskPath \"{path}\" | Where State -ne \"Disabled\" | Get-ScheduledTaskInfo | Where LastTaskResult -ne 0 > \"{outPut}\"\"";

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.Start();

            cmd.StandardInput.WriteLine(comando);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            return Formatar(outPut);
        }
        public List<Tarefa> Formatar(string caminho)
        {
            List<Tarefa> ListaTarefas = new List<Tarefa>();
            using (StreamReader sr = new StreamReader(caminho))
            {
                var arquivo = sr.ReadToEnd();
                var divisao = arquivo.Split("PSComputerName     :");
                foreach (var bloco in divisao)
                {
                    ListaTarefas.Add(Instanciar(bloco));
                }
            }
            File.Delete(caminho);
            return ListaTarefas;
        }
        private Tarefa Instanciar(string texto)
        {
            
            
            using (StringReader str = new StringReader(texto))
            {
                Tarefa task = new Tarefa();
                string linha;
                while ((linha = str.ReadLine()) != null)
                {
                    if (linha.Contains("LastRunTime        : "))
                    {
                        var data = linha.Replace("LastRunTime        : ", "");
                        if(data != "")
                        {
                            task.UltimaExecucao = DateTime.ParseExact(data, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            task.UltimaExecucao = null;
                        }
                    }
                    else if (linha.Contains("LastTaskResult     : "))
                    {
                        task.UltimoResultado =
                            linha.Replace("LastTaskResult     : ", "");
                    }
                    else if (linha.Contains("NextRunTime        : "))
                    {
                        var data = linha.Replace("NextRunTime        : ", "");
                        if (data != "")
                        {
                            task.ProximaExecucao = DateTime.ParseExact(data, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            task.ProximaExecucao = null;
                        }
                    }
                    else if (linha.Contains("TaskName           : "))
                    {
                        task.NomeTarefa =
                            linha.Replace("TaskName           : ", "");
                    }
                    else if (linha.Contains("TaskPath           : "))
                    {
                        task.Caminho =
                            linha.Replace("TaskPath           : ", "");
                    }
                }

                task.Cliente = task.Caminho;

                return task;
            }
        }
    }
}
