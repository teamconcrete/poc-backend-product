using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommerce.Domain.Validation;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Domain.Interfaces.Service.Common
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