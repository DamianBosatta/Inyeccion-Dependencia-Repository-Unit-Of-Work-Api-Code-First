using Concecionaria.Date;
using Concecionaria.Entity;
using Concecionaria.Repository.Interfaces;

namespace Concecionaria.Repository.Clases
{
    public class RepositoryVentas : GenericRepository<Ventas>, IRepositoryVentas
    {
        public RepositoryVentas(ApplicationDbContext db) : base(db)
        {
        }
    }
}
