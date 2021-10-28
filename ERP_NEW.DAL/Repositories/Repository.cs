using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.DAL.EF;
using ERP_NEW.DAL.Interfaces;
using FirebirdSql.Data.FirebirdClient;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;

namespace ERP_NEW.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ERP_Context db;
        public static FbTransaction Transaction;

        public Repository(ERP_Context context)
        {
            this.db = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
            return db.Set<T>().Local.Last();
        }

        public void CreateRange(IEnumerable<T> entity)
        {
            db.Set<T>().AddRange(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public void DeleteAll(IEnumerable<T> entity)
        {
            db.Set<T>().RemoveRange(entity);
            db.SaveChanges();
        }

        public IEnumerable<T> SQLExecuteProc(string executeProcString, params FbParameter[] paramArr)
        {
            return db.Set<T>().SqlQuery(executeProcString, paramArr);
        }



        //public void SQLExecuteScript(string executeProcString, params FbParameter[] paramArr)
        //{
        //    db.Set<T>().SqlQuery(executeProcString, paramArr);
        //    db.SaveChanges();
        //    //return db.Set<T>().SqlQuery(executeProcString, paramArr);
        //}
    }
}
