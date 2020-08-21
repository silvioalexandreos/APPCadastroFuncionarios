using Microsoft.EntityFrameworkCore;


namespace CadFuncionario
{
    public class Conexao : DbContext
    {
        public DbSet<Nivel> Niveis { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CadDevDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}