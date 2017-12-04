using ViaUnica.Domain.Entities;
using System.Threading.Tasks;

namespace ViaUnica.Domain.Interfaces.Repository.Common
{
    public interface IRepositoryAsync<TEntity> : IReadOnlyRepositoryAsync<TEntity> where TEntity : Entity
    {
        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}