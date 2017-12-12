using Ecommerce.Domain.ExternalServices.Models;

namespace Ecommerce.Domain.ExternalServices.Requests
{
    public class ObterProdutoRequest
    {
        public int? IdProduto { get; set; }
        
        public int? IdSku { get; set; }
        
        public Composicao Composicao { get; set; }
    }
}
