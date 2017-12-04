﻿using ViaUnica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ViaUnica.Application.Interfaces.Common
{
    public interface IReadOnlyAppServiceAsync<TEntity> where TEntity : Entity
    {
        Task<TEntity> GetAsync(Guid id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);
    }
}