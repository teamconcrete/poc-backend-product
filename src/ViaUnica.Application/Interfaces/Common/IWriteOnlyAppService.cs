using ViaUnica.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ViaUnica.Application.Interfaces.Common
{
    public interface IWriteOnlyAppService<TEntity> where TEntity : Entity
    {
        ValidationResult Create(TEntity entity);

        ValidationResult Update(TEntity entity);

        bool Delete(TEntity entity);
    }
}