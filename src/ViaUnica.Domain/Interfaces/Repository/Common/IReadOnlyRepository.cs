﻿using ViaUnica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ViaUnica.Domain.Interfaces.Repository.Common
{
    public interface IReadOnlyRepository<TEntity> where TEntity : Entity
    {
        TEntity Get(Guid id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    }
}