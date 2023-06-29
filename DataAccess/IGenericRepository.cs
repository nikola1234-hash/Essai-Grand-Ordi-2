using Essai_Grand_Ordi_1.DataAccess.Entities;
using System.Collections.Generic;

namespace Essai_Grand_Ordi_1.DataAccess
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        long Insert(T entity);
        void Update(T entity);
    }
}