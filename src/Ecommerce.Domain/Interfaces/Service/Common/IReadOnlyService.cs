﻿using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Ecommerce.Domain.Interfaces.Service.Common
{
    public interface IReadOnlyService<TEntity> where TEntity : Entity
    {
        TEntity Get(Guid id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    }
}