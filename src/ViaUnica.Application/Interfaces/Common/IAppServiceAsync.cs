using ViaUnica.Domain.Entities;
using System;

namespace ViaUnica.Application.Interfaces.Common
{
    public interface IAppServiceAsync<TEntity> : IWriteOnlyAppServiceAsync<TEntity>, IReadOnlyAppServiceAsync<TEntity> where TEntity : Entity
    {
    }
}