using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Application
{
    public class ProductAppService : AppService, IProductAppService
    {
        private readonly IProductService _service;

        public ProductAppService(IProductService productService)
        {
            _service = productService;
        }

        public async Task<Product> GetAsync(Guid id)
        {
            return await _service.GetAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        public async Task<IEnumerable<Product>> FindAsync(Func<Product, bool> predicate)
        {
            return await _service.FindAsync(predicate);
        }
        
        public async Task<ValidationResult> CreateAsync(Product entity)
        {
            ValidationResult.Add(await _service.AddAsync(entity));

            return ValidationResult;
        }

        public async Task<ValidationResult> UpdateAsync(Product entity)
        {
            ValidationResult.Add(await _service.UpdateAsync(entity));

            return ValidationResult;
        }

        public async Task<ValidationResult> DeleteAsync(Product entity)
        {
            ValidationResult.Add(await _service.DeleteAsync(entity));

            return ValidationResult;
        }
    }
}
