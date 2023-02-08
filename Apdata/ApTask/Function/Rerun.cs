using System.Diagnostics;

namespace ApTask
{
    public class Rerun : Base
    {
        public Rerun() { }

        public override void Go()
        {
            foreach(var task in TaskList
                                    .Where(x => x.Rerun == true &&
                                                x.Attempts < int.Parse(Cfgs["Attempt"])))
            {
                using (var process = new Process())
                {
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = Cfgs[this.GetType().Name]
                                                           .Replace("#Servidor#", task.HostName)
                                                           .Replace("#Tarefa#", task.TaskName);
                    var result = true;
                    Console.WriteLine(process.StartInfo.Arguments);
                    try { process.Start(); }
                    catch { result = false; }
                    
                    new Log(
                        taskName:$"{task.TaskName} [{task.HostName}]",
                        method:"Rerun.Go()",
                        description: $"Execução de uma nova instância do Scheduler que retornou erro [Status: {task.Status}, Last Result: {task.LastResult}, Attempts: {task.Attempts}, Comando: {process.StartInfo.Arguments}]",
                        result: result);
                }
                task.LastUpdate = DateTime.Now;
                task.Attempts += 1;
                Ctx.Update(task);
                Ctx.SaveChanges();
            }
        }
    }
}
