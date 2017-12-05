using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repository;
using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Services.Common;
using Ecommerce.Domain.Validation;
using Ecommerce.Domain.Interfaces.Validation;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services
{
    public class ProductService : ServiceAsync<Product>, IProductService
    {
        public ProductService(IProductRepository repository) : base(repository)
        {
        }

        public override async Task<ValidationResult> AddAsync(Product entity)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            if (entity is ISelfValidation selfValidationEntity && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            await Repository.AddAsync(entity);

            return ValidationResult;
        }
    }
}

