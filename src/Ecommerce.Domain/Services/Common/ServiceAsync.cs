using Ecommerce.Domain.Interfaces.Repository.Common;
using Ecommerce.Domain.Interfaces.Service.Common;
using Ecommerce.Domain.Validation;
using Ecommerce.Domain.Interfaces.Validation;
using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services.Common
{
    public class ServiceAsync<TEntity> : IServiceAsync<TEntity> where TEntity : Entity
    {
        private readonly IRepositoryAsync<TEntity> _repository;
        private readonly ValidationResult _validationResult;

        public ServiceAsync(IRepositoryAsync<TEntity> repository)
        {
            _repository = repository;
            _validationResult = new ValidationResult();
        }

        protected IRepositoryAsync<TEntity> Repository
        {
            get { return _repository; }
        }

        protected ValidationResult ValidationResult
        {
            get { return _validationResult; }
        }

        public virtual async Task<TEntity> GetAsync(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate)
        {
            return await _repository.FindAsync(predicate);
        }

        public virtual async Task<ValidationResult> AddAsync(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            if (entity is ISelfValidation selfValidationEntity && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            await _repository.AddAsync(entity);
            return _validationResult;
        }

        public virtual async Task<ValidationResult> UpdateAsync(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            if (entity is ISelfValidation selfValidationEntity && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            await _repository.UpdateAsync(entity);
            return _validationResult;
        }

        public virtual async Task<ValidationResult> DeleteAsync(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            await _repository.DeleteAsync(entity);

            return _validationResult;
        }

        public virtual async Task<ValidationResult> DeleteAsync(Guid id)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            var entity = await _repository.GetAsync(id);

            await _repository.DeleteAsync(entity);

            return _validationResult;
        }
    }
}
