using Essai_Grand_Ordi_1.DataAccess.Entities;

namespace Essai_Grand_Ordi_1.DataAccess
{
    public interface IUnitOfWork
    {
        IGenericRepository<City> City { get; }
        IGenericRepository<Client> Client { get; }
        IGenericRepository<Menu> Menu { get; }
        IGenericRepository<OrderDetails> OrderDetils { get; }
        IGenericRepository<OrderMethod> OrderMethod { get; }
        IGenericRepository<Orders> Orders { get; }
        IGenericRepository<Payments> Payments { get; }
    }
}