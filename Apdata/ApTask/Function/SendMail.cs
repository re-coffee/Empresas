using System.Net.Mail;

namespace ApTask
{
    public class SendMail : Base
    {
        public SendMail() { }
        public override void Go()
        {
            Console.WriteLine("Iniciei o SendMail()");
            foreach (var task in TaskList
                                    .Where(x => x.SendMail == true &&
                                                x.MailTo is not null)
                                    .Where(x => !Ctx.Logs.Any(e => e.TaskName == x.TaskName &&
                                                                   e.Method == "SendMail.Go()" &&
                                                                   e.Result == true &&
                                                                   e.LastRunTime == x.LastRunTime)))
            {
                Console.WriteLine("Entrei no foreach");
                MailMessage email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(Cfgs["MailSmtp"], int.Parse(Cfgs["MailPort"]));
                email.From = new MailAddress(Cfgs["MailFrom"]);
                SmtpServer.EnableSsl = Cfgs["MailSsl"] == "1";
                email.Subject = Replace(Cfgs["MailSubject"], task);
                email.Body = Replace(Cfgs["MailHtml"], task);
                email.CC.Add(email.From);
                email.IsBodyHtml = true;

                foreach (var receiver in task.MailTo.Split(';').Where(x => !string.IsNullOrEmpty(x)))
                {
                    email.To.Add(receiver.Trim());
                }

                var result = true;
                try
                {
                    SmtpServer.Send(email);
                }
                catch { result = false; }

                new Log(
                        taskName: task.TaskName,
                        lastRunTime: task.LastRunTime,
                        method: "SendMail.Go()",
                        description: $"Disparo de aviso sobre o Scheduler que retornou erro [Status: {task.Status}, Last Result: {task.LastResult}, Attempts: {task.Attempts}, Mail To: {task.MailTo}, Body: {email.Body}]",
                        result: result); ;
            }
            Console.WriteLine("Finalizei sem erros");
        }
        public string Replace(string value, Task task)
        {
            return value
                        .Replace("#HostName#", task.HostName)
                        .Replace("#TaskName#", task.TaskName)
                        .Replace("#NextRunTime#", task.NextRunTime?.ToString("dd/MM/yyyy HH:mm"))
                        .Replace("#Status#", task.Status)
                        .Replace("#LastRunTime#", task.LastRunTime?.ToString("dd/MM/yyyy HH:mm"))
                        .Replace("#LastResult#", task.LastResult)
                        .Replace("#TaskToRun#", task.TaskToRun)
                        .Replace("#Comment#", task.Comment)
                        .Replace("#ScheduledTaskState#", task.ScheduledTaskState)
                        .Replace("#Description#", task.Description)
                        .Replace("#Show#", task.Show.ToString())
                        .Replace("#Rerun#", task.Rerun.ToString())
                        .Replace("#Force#", task.Force.ToString())
                        .Replace("#SendMail#", task.SendMail.ToString())
                        .Replace("#MailTo#", task.MailTo)
                        .Replace("#ServiceName#", task.ServiceName)
                        .Replace("#Attempts#", task.Attempts.ToString())
                        .Replace("#LastStopStart#", task.LastStopStart?.ToString("dd/MM/yyyy HH:mm"));
        }
    }
}
