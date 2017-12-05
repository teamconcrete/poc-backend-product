using Ecommerce.Domain.Validation;

namespace Ecommerce.Application
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
