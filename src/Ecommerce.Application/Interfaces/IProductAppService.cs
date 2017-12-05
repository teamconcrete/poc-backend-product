using Ecommerce.Application.Interfaces.Common;
using Ecommerce.Domain.Entities;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interfaces
{
    public interface IProductAppService : IAppServiceAsync<Product>
    {
    }
}
