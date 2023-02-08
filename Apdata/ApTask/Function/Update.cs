using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace ApTask
{
    public class Update : Base
    {
        public Update()
        {
            GetTasks();
            UpdateTasks();
        }
        
        public List<Task> Tasks { get; set; } = new List<Task>();

        public void GetTasks()
        {
            foreach (var server in Cfgs["Server"].Split("|"))
            {
                try
                {
                    using (var process = new Process())
                    {
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.StandardOutputEncoding = Encoding.GetEncoding("utf-8");
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.Arguments = Cfgs[this.GetType().Name].Replace("#TaskRoot#", Cfgs["TaskRoot"]).Replace("#Servidor#", server);
                        process.Start();

                        foreach (var task in process.StandardOutput.ReadToEnd().Split(Environment.NewLine + Environment.NewLine))
                        {
                            try { Tasks.Add(Instance(task)); }
                            catch { continue; }
                        }
                    }
                }
                catch { continue; }
            }
        }

        public void UpdateTasks()
        {
            foreach (var task in Tasks)
            {
                try { task.Save(); }
                catch { continue; }
            }
        }

        public Task Instance(string task)
        {
            var props = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var line in task.Split(Environment.NewLine))
            {
                var split = line.Split(':', 2);
                try { props.Add(split[0].Trim(), split[1].Trim()); }
                catch { continue; }
            }
            if (props["TaskName"] is null) throw new ArgumentException();
            DateTime? nextRunTime;
            DateTime? lastRunTime;
            try { nextRunTime = DateTime.ParseExact(props["Next Run Time"], Cfgs["DateFormat"], CultureInfo.InvariantCulture); }
            catch { nextRunTime = null; }

            try { lastRunTime = DateTime.ParseExact(props["Last Run Time"], Cfgs["DateFormat"], CultureInfo.InvariantCulture); }
            catch { lastRunTime = null; }

            return
                new Task(
                    hostName: props["HostName"],
                    taskName: props["TaskName"],
                    nextRunTime: nextRunTime,
                    status: props["Status"],
                    lastRunTime: lastRunTime,
                    lastResult: props["Last Result"],
                    taskToRun: props["Task To Run"],
                    comment: props["Comment"],
                    scheduledTaskState: props["Scheduled Task State"]);
        }
    }
}
