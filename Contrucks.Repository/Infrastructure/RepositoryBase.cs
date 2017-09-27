using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Contrucks.Repository.Infrastructure
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private ConTruckContext dataContext;
        private readonly IDbSet<T> dbset;
        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }
        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }
        protected ConTruckContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> query = dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }
        public virtual T GetByID(object id)
        {
            return dbset.Find(id);
        }
        public virtual IEnumerable<T> GetFulfilledPostsData()
        {
            return dbset.ToList();
        }

    }
}
