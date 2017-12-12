namespace Ecommerce.Domain.ExternalServices.Models
{
    public class SkuServico
    {
        public int IdSkuServico { get; set; }

        public int? Tipo { get; set; }

        public string Nome { get; set; }

        public int? Prazo { get; set; }

        public decimal? Preco { get; set; }
    }
}
