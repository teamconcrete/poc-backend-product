namespace Ecommerce.Domain.ExternalServices.Models
{
    public class Sku
    {
        public int IdSku { get; set; }

        public string Nome { get; set; }

        public string NomeCompleto { get; set; }

        public int? OrdemExibicao { get; set; }

        public int? IdArquivoThumbnail { get; set; }

        public bool? FlagAtiva { get; set; }

        public Produto Produto { get; set; }

        public SkuLojista[] SkuLojistas { get; set; }

        public Imagem[] Imagens { get; set; }

        public SkuServico[] Servicos { get; set; }

        public CampoValorGrupo[] FichaTecnica { get; set; }
    }
}
