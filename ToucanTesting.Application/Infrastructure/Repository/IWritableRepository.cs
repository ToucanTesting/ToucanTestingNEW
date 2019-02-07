using System;
using System.Collections.Generic;
using System.Text;

namespace ToucanTesting.Application.Infrastructure.Repositories
{
    public interface IWritableRepository<TEntity, TDto> where TEntity : class where TDto : class
    {
        void Add(TDto dto);
        void AddRange(IEnumerable<TDto> dtos);
    }
}
