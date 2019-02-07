using System;
using System.Collections.Generic;
using System.Text;

namespace ToucanTesting.Application.Infrastructure.Repositories
{
    public interface IReadableRepository<TEntity, TDto> where TEntity : class where TDto : class
    {
        TDto Get(Guid id);
        IEnumerable<TDto> GetAll();
    }
}
