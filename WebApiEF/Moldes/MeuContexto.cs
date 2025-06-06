using Microsoft.EntityFrameworkCore;

namespace WebApiEF.Moldes
{
    public class MeuContexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDatabase");

        public DbSet<Cliente> Clientes { get; set; }
    }
}

