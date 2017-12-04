using ViaUnica.Domain.Entities;
using ViaUnica.Domain.Interfaces.Repository;
using ViaUnica.Domain.Interfaces.Service;
using ViaUnica.Domain.Services.Common;
using ViaUnica.Domain.Validation;
using ViaUnica.Domain.Interfaces.Validation;
using System.Threading.Tasks;

namespace ViaUnica.Domain.Services
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

