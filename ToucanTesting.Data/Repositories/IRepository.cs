using System;
using System.Collections.Generic;
using System.Text;

namespace ToucanTesting.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Guid id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity item);
        void AddRange(IEnumerable<TEntity> items);
        void Remove(TEntity item);
        void RemoveRange(IEnumerable<TEntity> items);
    }
}
