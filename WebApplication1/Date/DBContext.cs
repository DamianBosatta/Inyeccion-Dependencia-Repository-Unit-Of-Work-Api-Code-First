using Concecionaria.Entity;
using Microsoft.EntityFrameworkCore;

namespace Concecionaria.Date
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Vehiculo>? Vehiculo { get; set; }
        public DbSet<Ventas>? Ventas { get; set; }
    }
}

