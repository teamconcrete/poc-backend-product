using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Ecommerce.Domain.Interfaces.Repository.Common
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        TEntity Get(Guid id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    }
}