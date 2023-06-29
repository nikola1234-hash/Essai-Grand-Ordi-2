using Essai_Grand_Ordi_1.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essai_Grand_Ordi_1.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {


        public IGenericRepository<City> City { get; }
        public IGenericRepository<Client> Client { get; }
        public IGenericRepository<Menu> Menu { get; set; }
        public IGenericRepository<OrderDetails> OrderDetils { get; }
        public IGenericRepository<OrderMethod> OrderMethod { get; }
        public IGenericRepository<Orders> Orders { get; set; }
        public IGenericRepository<Payments> Payments { get; }


        public UnitOfWork()
        {
            City = new GenericRepository<City>();
            Client = new GenericRepository<Client>();
            Menu = new GenericRepository<Menu>();
            OrderDetils = new GenericRepository<OrderDetails>();
            OrderMethod = new GenericRepository<OrderMethod>();
            Orders = new GenericRepository<Orders>();
            Payments = new GenericRepository<Payments>();

        }
    }
}
