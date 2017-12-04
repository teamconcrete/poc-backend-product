using ViaUnica.Domain.Entities;
using ViaUnica.Domain.Validation;
using System.Threading.Tasks;

namespace ViaUnica.Application.Interfaces.Common
{
    public interface IWriteOnlyAppServiceAsync<TEntity> where TEntity : Entity
    {
        Task<ValidationResult> CreateAsync(TEntity entity);

        Task<ValidationResult> UpdateAsync(TEntity entity);

        Task<ValidationResult> DeleteAsync(TEntity entity);
    }
}