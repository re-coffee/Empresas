using System.Diagnostics;

namespace ApTask
{
    public class Force : Base
    {
        public Force() { }

        public override void Go()
        {
            foreach(var task in TaskList
                                    .Where(x => x.Force == true &&
                                                x.Attempts >= int.Parse(Cfgs["Attempts"]) &&
                                               (x.LastStopStart?.Date < DateTime.Now.Date ||
                                                x.LastStopStart is null)))
            {
                using (var process = new Process())
                {
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = Cfgs[this.GetType().Name]
                                                           .Replace("#Servidor#", task.HostName)
                                                           .Replace("#Servico#", task.ServiceName)
                                                           .Replace("#Tarefa#", task.TaskName);
                    var result = true;
                    try { process.Start(); }
                    catch { result = false; }

                    new Log(
                        taskName: task.TaskName,
                        lastRunTime: task.LastRunTime,
                        method: "Force.Go()",
                        description: $"Execução do comando de Force e nova execução da Task [Status: {task.Status}, Last Result: {task.LastResult}, Comando: {process.StartInfo.Arguments}]",
                        result: result);
                }
                task.LastUpdate = DateTime.Now;
                task.LastStopStart = DateTime.Now;
                Ctx.Update(task);
                Ctx.SaveChanges();
            }
        }
    }
}
