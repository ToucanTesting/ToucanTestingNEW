﻿using System;
using System.Collections.Generic;

namespace ToucanTesting.Application.Infrastructure.Repository
{
    public interface IRepository<TEntity, TDto> :
        IWritableRepository<TEntity, TDto>,
        IReadableRepository<TEntity, TDto>,
        IRemovableRepository<TEntity, TDto>
        where TEntity : class where TDto : class
    {
    }
}