using Ecommerce.Domain.Entities;
using System;

namespace Ecommerce.Application.Interfaces.Common
{
    public interface IAppService<TEntity> : IWriteOnlyAppService<TEntity>, IReadOnlyAppService<TEntity>, IDisposable where TEntity : Entity
    {
    }
}