using ViaUnica.Domain.Entities;
using ViaUnica.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ViaUnica.Data.Mocks
{
    public class ProductRepositoryMock : IProductRepository
    {
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(GetAllMocked());
        }

        public async Task<Product> GetAsync(Guid id)
        {
            var products = await Task.FromResult(GetAllMocked());
            var product = products.FirstOrDefault();
            product.Id = id;

            return product;
        }

        public async Task<IEnumerable<Product>> FindAsync(Func<Product, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        private List<Product> GetAllMocked()
        {
            var result = new List<Product>();
            
            for(var i = 0; i < 10; i++)
            {
                var id = Guid.NewGuid();

                var product = new Product()
                {
                    Id = id,
                    Name = $"Produto {i}",
                    Description = $"O Produto {i} tem as seguintes características, as seguintes dimensões e é sensacional.",
                    ImageUrl = $"https://cdn.viaunica.com.br/images/{id}",
                    LastModified = DateTime.Now                   
                };

                result.Add(product);
            }

            return result;
        }
    }
}
