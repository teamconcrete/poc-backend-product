using Ecommerce.Domain.Entities;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Interfaces.Repository.Common
{
    public interface IRepositoryAsync<TEntity> : IReadOnlyRepositoryAsync<TEntity> where TEntity : Entity
    {
        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}