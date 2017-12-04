using ViaUnica.Application.Interfaces.Common;
using ViaUnica.Domain.Entities;
using System.Threading.Tasks;

namespace ViaUnica.Application.Interfaces
{
    public interface IProductAppService : IAppServiceAsync<Product>
    {
    }
}
