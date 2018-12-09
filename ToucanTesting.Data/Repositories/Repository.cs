using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToucanTesting.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ToucanDbContext Context;

        public Repository(ToucanDbContext context)
        {
            Context = context;
        }
        public TEntity Get(Guid id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Add(TEntity item)
        {
            Context.Set<TEntity>().Add(item);
        }

        public void AddRange(IEnumerable<TEntity> items)
        {
            Context.Set<TEntity>().AddRange(items);
        }

        public void Remove(TEntity item)
        {
            Context.Set<TEntity>().Remove(item);
        }

        public void RemoveRange(IEnumerable<TEntity> items)
        {
            Context.Set<TEntity>().RemoveRange(items);
        }
    }
}
