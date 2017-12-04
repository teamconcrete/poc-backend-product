using ViaUnica.Domain.Validation;

namespace ViaUnica.Domain.Interfaces.Validation
{
    public interface IValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}