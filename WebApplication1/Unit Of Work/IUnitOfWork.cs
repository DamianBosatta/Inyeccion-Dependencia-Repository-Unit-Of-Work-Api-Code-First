using Concecionaria.Repository.Interfaces;

namespace Concecionaria.Unit_Of_Work
{
    public interface IUnitOfWork : IDisposable

    {



        IRepositoryCliente ClienteRepo { get; }
        IRepositoryVentas VentaRepo { get; }
        IRepositoryVehiculo VehiculoRepo { get; }
        void Save();


    }
}
