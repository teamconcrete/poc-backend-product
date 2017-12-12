using Ecommerce.Domain.ExternalServices.Models;

namespace Ecommerce.Domain.ExternalServices.Requests
{
    public class ObterProdutosPorIdsRequest
    {
        public int[] IdsProdutos { get; set; }
        
        public int[] IdsSkus { get; set; }
        
        public Composicao Composicao { get; set; }

        public int? Pagina { get; set; }

        public int? RegistrosPorPagina { get; set; }

        public string Ordenacao { get; set; }

        public string TipoOrdenacao { get; set; }
    }
}
