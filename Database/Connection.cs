using Microsoft.EntityFrameworkCore;
using UI;

namespace CadFuncionario
{
    public class Connection : DbContext
    {
        public DbSet<Level> Niveis { get; set; }
        public DbSet<Developer> Desenvolvedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CadDevDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}