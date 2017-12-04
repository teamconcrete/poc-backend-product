using ViaUnica.Domain.Interfaces.Repository.Common;
using ViaUnica.Domain.Interfaces.Service.Common;
using ViaUnica.Domain.Validation;
using ViaUnica.Domain.Interfaces.Validation;
using ViaUnica.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ViaUnica.Domain.Services.Common
{
    public class Service<TEntity> : IService<TEntity> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository;
        private readonly ValidationResult _validationResult;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
            _validationResult = new ValidationResult();
        }

        protected IRepository<TEntity> Repository
        {
            get { return _repository; }
        }

        protected ValidationResult ValidationResult
        {
            get { return _validationResult; }
        }

        public virtual TEntity Get(Guid id)
        {
            return _repository.Get(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _repository.Find(predicate);
        }

        public virtual ValidationResult Add(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            if (entity is ISelfValidation selfValidationEntity && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;


            _repository.Add(entity);
            return _validationResult;
        }

        public virtual ValidationResult Update(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            if (entity is ISelfValidation selfValidationEntity && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            _repository.Update(entity);
            return _validationResult;
        }

        public virtual ValidationResult Delete(TEntity entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            _repository.Delete(entity);
            return _validationResult;
        }

        public ValidationResult Delete(Guid id)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            var entity = _repository.Get(id);

            _repository.Delete(entity);
            return _validationResult;
        }
    }
}
