using Concecionaria.Date;
using Concecionaria.Entity;
using Concecionaria.Repository.Interfaces;

namespace Concecionaria.Repository.Clases
{
    public class RepositoryCliente : GenericRepository<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(ApplicationDbContext db) : base(db)
        {
        }
    }
}
