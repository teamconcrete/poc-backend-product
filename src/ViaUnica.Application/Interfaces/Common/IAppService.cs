using ViaUnica.Domain.Entities;
using System;

namespace ViaUnica.Application.Interfaces.Common
{
    public interface IAppService<TEntity> : IWriteOnlyAppService<TEntity>, IReadOnlyAppService<TEntity>, IDisposable where TEntity : Entity
    {
    }
}