using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Ecommerce.Application.Interfaces.Common
{
    public interface IReadOnlyAppService<TEntity> where TEntity : Entity
    {
        TEntity Get(Guid id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    }
}