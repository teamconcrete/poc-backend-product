using Ecommerce.Domain.ExternalServices.Models;

namespace Ecommerce.Domain.ExternalServices.Responses
{
    public class ObterProdutosPorIdsResponse
    {
        public Produto[] Produtos { get; set; }

        public bool? Valido { get; set; }

        public Mensagem[] Mensagens { get; set; }

        public string Protocolo { get; set; }
    }
}