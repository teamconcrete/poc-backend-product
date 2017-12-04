using ViaUnica.Domain.Validation;

namespace ViaUnica.Domain.Interfaces.Validation
{
    public interface ISelfValidation
    {
        ValidationResult ValidationResult { get; }

        bool IsValid { get; }
    }
}