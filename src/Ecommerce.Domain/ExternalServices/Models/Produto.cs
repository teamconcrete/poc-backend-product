using System;

namespace Ecommerce.Domain.ExternalServices.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string Nome { get; set; }

        public CategoriaProduto Categoria { get; set; }

        public Marca Marca { get; set; }

        public string Descricao { get; set; }

        public Sku[] Skus { get; set; }

        public CampoValorGrupo[] FichaTecnica { get; set; }

        public Imagem[] Imagens { get; set; }

        public string Canonical { get; set; }

        public bool? FlagRetiraEmLoja { get; set; }

        public Produto[] ToList()
        {
            throw new NotImplementedException();
        }
    }
}
