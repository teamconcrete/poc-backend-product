using System;
using Ecommerce.Domain.Entities.Specifications.ProductSpecs;
using Ecommerce.Domain.Validation;

namespace Ecommerce.Domain.Entities.Validations
{
    public class ProductIsValidValidation : Validation<Product>
    {
        public ProductIsValidValidation()
        {
            base.AddRule(new ValidationRule<Product>(new ProductNameIsRequiredSpec(), "Product short description is required"));
        }

        internal ValidationResult Valid(Configuration configuration)
        {
            throw new NotImplementedException();
        }
    }
}
