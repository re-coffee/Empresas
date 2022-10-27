using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Panteao
{
    public class Context : DbContext
    {
        public Context() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(StringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }
        public DbSet<Arquivo>? Arquivos { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Servico>? Servicos { get; set; }
        public DbSet<TipoServico>? TiposServicos { get; set; }
        public DbSet<Servidor>? Servidores { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Contrato>? Contratos { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Menu>? Menus { get; set; }
        public DbSet<RoleMenu>? RolesMenus { get; set; }
        public DbSet<Relatorio>? Relatorios { get; set; }
        public DbSet<Parametro>? Parametros { get; set; }

        public static string StringConexao()
        {
            return new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build().GetConnectionString("Context");
        }
    }
}
