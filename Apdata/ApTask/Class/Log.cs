using Microsoft.EntityFrameworkCore.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApTask
{
    [Table("Log")]
    public class Log
    {
        public Log(string taskName, string method, string description, bool result)
        {
            TaskName = taskName;
            Method = method;
            Description = description;
            Result = result;
            Save();
        }

        [Key]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Method { get; set; }
        public string Description { get; set; }
        public bool Result { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public void Save()
        {
            new Context()
                .Add(this)
                .Context
                .SaveChanges();
        }
    }
}
