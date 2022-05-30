using Concecionaria.Date;
using Concecionaria.Repository.Clases;
using Concecionaria.Repository.Interfaces;

namespace Concecionaria.Unit_Of_Work
{
    public class UnitOfWork:IUnitOfWork

    {


        private readonly ApplicationDbContext _context;

        public IRepositoryCliente ClienteRepo { get; private set; }

        public IRepositoryVentas VentaRepo { get; private set; }

        public IRepositoryVehiculo VehiculoRepo { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ClienteRepo = new RepositoryCliente(context);
            VentaRepo = new RepositoryVentas(context);
            VehiculoRepo = new RepositoryVehiculo(context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
