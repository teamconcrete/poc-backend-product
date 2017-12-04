using ViaUnica.Domain.Entities;
using ViaUnica.Domain.Interfaces.Repository.Common;

namespace ViaUnica.Domain.Interfaces.Repository
{
    public interface IProductRepository : IRepositoryAsync<Product>
    {
    }
}
