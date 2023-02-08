using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApTask
{
    [Table("Task")]
    public partial class Task
    {
        public Task() { }
        public Task(string hostName, string taskName, DateTime? nextRunTime, string status, DateTime? lastRunTime, string lastResult, string taskToRun, string comment, string scheduledTaskState)
        {
            this.HostName = hostName;
            this.TaskName = taskName;
            this.NextRunTime = nextRunTime;
            this.Status = status;
            this.LastRunTime = lastRunTime;
            this.LastResult = lastResult;
            this.TaskToRun = taskToRun;
            this.Comment = comment;
            this.ScheduledTaskState = scheduledTaskState;
        }
        
        /*Task Scheduler*/
        public string HostName { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string TaskName { get; set; }
        public DateTime? NextRunTime { get; set; }
        public string Status { get; set; }
        public DateTime? LastRunTime { get; set; }
        public string LastResult { get; set; }
        public string TaskToRun { get; set; }
        public string Comment { get; set; }
        public string ScheduledTaskState { get; set; }

        /*ApTask*/
        public string? Description { get; set; }
        public bool Show { get; set; } = false;
        public bool Rerun { get; set; } = false;
        public bool Force { get; set; } = false;
        public bool SendMail { get; set; } = false;
        public string? MailTo { get; set; }
        public string? ServiceName { get; set; }
        public int Attempts { get; set; } = 0;
        public DateTime? LastStopStart { get; set; }
        public DateTime LastUpdate { get; set; } = DateTime.Now;

        public void Save()
        {
            using (var context = new Context())
            {
                var register = context.Tasks.Where(x => x.TaskName == this.TaskName).FirstOrDefault();
                var exists = (register?.TaskName ?? "") != "";
                if (exists)
                {
                    register.NextRunTime = this.NextRunTime;
                    register.Status = this.Status;
                    register.LastRunTime = this.LastRunTime;
                    register.LastResult = this.LastResult;
                    register.TaskToRun = this.TaskToRun;
                    register.Comment = this.Comment;
                    register.ScheduledTaskState = this.ScheduledTaskState;
                    register.LastUpdate = this.LastUpdate;
                    if (this.LastResult == "0" && this.Status == "Ready")
                        register.Attempts = 0;

                }
                else { context.Add(this); }
                context.SaveChanges();
            }
        }
    }
}
