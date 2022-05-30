using Concecionaria.Date;
using Concecionaria.Entity;
using Concecionaria.Repository.Interfaces;

namespace Concecionaria.Repository.Clases
{
    public class RepositoryVehiculo : GenericRepository<Vehiculo>, IRepositoryVehiculo
    {
        public RepositoryVehiculo(ApplicationDbContext db) : base(db)
        {
        }
    }
}
