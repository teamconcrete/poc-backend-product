using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repository.Common;

namespace Ecommerce.Domain.Interfaces.Repository
{
    public interface IProductRepository : IRepositoryAsync<Product>
    {
    }
}
