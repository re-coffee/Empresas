using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApTask
{
    internal class Context : DbContext
    {
        public Context() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString());
                base.OnConfiguring(optionsBuilder);
            }
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Configuration> Configurations { get; set; }


        public static string ConnectionString()
        {
            return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("Config.json")
                    .Build()
                    .GetConnectionString("Database");
        }
    }
}
