using ViaUnica.Domain.Interfaces.Repository.Common;
using ViaUnica.Domain.Interfaces.Service.Common;
using ViaUnica.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ViaUnica.Domain.Services.Common
{
    public class ReadOnlyService<TEntity> : IReadOnlyService<TEntity>
        where TEntity : Entity
    {
        private readonly IReadOnlyRepository<TEntity> _readOnlyRepository;

        public ReadOnlyService(
            IReadOnlyRepository<TEntity> readOnlyRepository)
        {
            _readOnlyRepository = readOnlyRepository;
        }

        protected IReadOnlyRepository<TEntity> ReadOnlyRepository
        {
            get { return _readOnlyRepository; }
        }

        public virtual TEntity Get(Guid id)
        {
            return _readOnlyRepository.Get(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _readOnlyRepository.GetAll();
        }

        public virtual IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _readOnlyRepository.Find(predicate);
        }
    }
}