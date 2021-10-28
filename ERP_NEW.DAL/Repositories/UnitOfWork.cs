using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.DAL.EF;
using ERP_NEW.DAL.Interfaces;
using System.Data.Entity.Core;

namespace ERP_NEW.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ERP_Context db;
        private bool disposed;
        private Dictionary<Type, object> repositories;

        public UnitOfWork()
        {
            db = new ERP_Context();
            repositories = new Dictionary<Type, object>();
            disposed = false;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            if (repositories.ContainsKey(typeof(T)))
            {
                return repositories[typeof(T)] as IRepository<T>;
            }

            var repository = new Repository<T>(db);

            repositories.Add(typeof(T), repository);

            return repository;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public bool GetExecuteSqlCommand(string str)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Database.ExecuteSqlCommand(str);
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch (OptimisticConcurrencyException)
                {

                }
            }





            //try
            //{
            //    db.Database.BeginTransaction();
            //    db.Database.ExecuteSqlCommand(str);
            //    db.SaveChanges();

            //    //db.Database.
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}

            return true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
