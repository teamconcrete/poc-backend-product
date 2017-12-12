using Ecommerce.Domain.ExternalServices.Requests;
using Ecommerce.Domain.ExternalServices.Responses;
using Refit;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ExternalServices
{
    public interface IProductExternalService
    {
        [Post("/ObterProduto")]
        Task<ObterProdutoResponse> ObterProduto([Body] ObterProdutoRequest request);

        [Post("/ObterProdutosPorIds")]
        Task<ObterProdutosPorIdsResponse> ObterProdutosPorIds([Body] ObterProdutosPorIdsRequest request);
    }
}
