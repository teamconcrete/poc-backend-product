using Ecommerce.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Interfaces.Common
{
    public interface IWriteOnlyAppService<TEntity> where TEntity : Entity
    {
        ValidationResult Create(TEntity entity);

        ValidationResult Update(TEntity entity);

        bool Delete(TEntity entity);
    }
}