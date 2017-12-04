using ViaUnica.Domain.Entities.Specifications.ProductSpecs;
using ViaUnica.Domain.Validation;

namespace ViaUnica.Domain.Entities.Validations
{
    public class ProductIsValidValidation : Validation<Product>
    {
        public ProductIsValidValidation()
        {
            base.AddRule(new ValidationRule<Product>(new ProductNameIsRequiredSpec(), "Product short description is required"));
        }
    }
}
