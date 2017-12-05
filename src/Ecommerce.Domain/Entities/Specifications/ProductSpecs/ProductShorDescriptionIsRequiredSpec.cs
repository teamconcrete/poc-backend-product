using Ecommerce.Domain.Interfaces.Specification;

namespace Ecommerce.Domain.Entities.Specifications.ProductSpecs
{
    public class ProductNameIsRequiredSpec : ISpecification<Product>
    {
        public bool IsSatisfiedBy(Product product)
        {
            return product.Name.Trim().Length > 0;
        }
    }
}
