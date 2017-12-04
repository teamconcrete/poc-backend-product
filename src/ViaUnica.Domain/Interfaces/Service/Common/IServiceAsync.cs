using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViaUnica.Domain.Validation;
using ViaUnica.Domain.Entities;

namespace ViaUnica.Domain.Interfaces.Service.Common
{
    public interface IServiceAsync<TEntity> where TEntity : Entity
    {
        Task<TEntity> GetAsync(Guid id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);

        Task<ValidationResult> AddAsync(TEntity entity);

        Task<ValidationResult> UpdateAsync(TEntity entity);

        Task<ValidationResult> DeleteAsync(TEntity entity);

        Task<ValidationResult> DeleteAsync(Guid id);
    }
}