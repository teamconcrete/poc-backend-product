using ViaUnica.Domain.Interfaces.Specification;

namespace ViaUnica.Domain.Entities.Specifications.ProductSpecs
{
    public class ProductNameIsRequiredSpec : ISpecification<Product>
    {
        public bool IsSatisfiedBy(Product product)
        {
            return product.Name.Trim().Length > 0;
        }
    }
}
