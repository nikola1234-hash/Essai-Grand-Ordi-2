using System.Collections.Generic;
using System.Data;
using System.Configuration;
using Essai_Grand_Ordi_1.DataAccess.Entities;
using System.Data.OleDb;
using Essai_Grand_Ordi_1.DataAccess.Extensions;

namespace Essai_Grand_Ordi_1.DataAccess
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Bakery"].ToString();
        public IEnumerable<T> GetAll()
        {
            using (IDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                return SqlExtension.GetAll<T>(connection);
            }
        }

        public T GetById(int id)
        {
            using (IDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                return SqlExtension.Get<T>(connection, id);
            }
        }

        public long Insert(T entity)
        {
            using (IDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                return SqlExtension.Insert(connection, entity);
                //connection.Insert(entity);
            }
        }

        public void Update(T entity)
        {
            using (IDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                SqlExtension.Update(connection, entity);
            }
        }

        public void Delete(T entity)
        {
            using (IDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                SqlExtension.Delete(connection, entity);
            }
        }
    }
}

