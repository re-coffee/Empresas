﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApDatabaseController.Classes
{
    internal class Contexto : DbContext
    {
        public Contexto() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(StringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }
        public DbSet<Controle>? Controles { get; set; }
        public DbSet<Servidor>? Servidores { get; set; }

        public static string StringConexao()
        {
            return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build()
                    .GetConnectionString("Contexto");
        }
    }
}
