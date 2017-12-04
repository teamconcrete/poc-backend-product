﻿using ViaUnica.Domain.Validation;
using ViaUnica.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ViaUnica.Domain.Interfaces.Service.Common
{
    public interface IService<TEntity> where TEntity : Entity
    {
        TEntity Get(Guid id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);

        ValidationResult Add(TEntity entity);

        ValidationResult Update(TEntity entity);

        ValidationResult Delete(TEntity entity);

        ValidationResult Delete(Guid id);
    }
}