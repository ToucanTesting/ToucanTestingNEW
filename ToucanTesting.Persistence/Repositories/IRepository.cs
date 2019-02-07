using System;
using System.Collections.Generic;

namespace ToucanTesting.Persistence.Repositories
{
    public interface IRepository<TEntity, TDto> where TEntity : class where TDto : class
    {
        TDto Get(Guid id);
        IEnumerable<TDto> GetAll();
        void Add(TDto dto);
        void AddRange(IEnumerable<TDto> dtos);
        void Remove(TDto dto);
        void RemoveRange(IEnumerable<TDto> dtos);
    }
}
