namespace Ecommerce.Domain.ExternalServices.Models
{
    public class Imagem
    {
        public int IdArquivo { get; set; }

        public string Nome { get; set; }

        public int? Largura { get; set; }

        public int? Altura { get; set; }

        public string Url { get; set; }

        public int? IdArquivoRelacionado { get; set; }
    }
}
