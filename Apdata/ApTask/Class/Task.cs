using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApTask
{
    internal partial class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime NextRunTime { get; set; }
        public DateTime LastRunTime { get; set; }
        public string LastRunResult { get; set; }
        public bool Monitor { get; set; } = true;
        public bool Force { get; set; } = false;
        public string? ServiceName { get; set; }
        public DateTime? LastStopStart { get; set; }
        public int Attempts { get; set; } = 0;
        public bool SendMail { get; set; } = false;
        public string? Receiver { get; set; }

    }
}
