using Ecommerce.Domain.Entities;
using System;

namespace Ecommerce.Application.Interfaces.Common
{
    public interface IAppServiceAsync<TEntity> : IWriteOnlyAppServiceAsync<TEntity>, IReadOnlyAppServiceAsync<TEntity> where TEntity : Entity
    {
    }
}