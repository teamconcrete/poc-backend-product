using ViaUnica.Domain.Validation;

namespace ViaUnica.Application
{
    public class AppService
    {
        public AppService()
        {
            ValidationResult = new ValidationResult();
        }

        protected ValidationResult ValidationResult { get; private set; }        
    }
}
