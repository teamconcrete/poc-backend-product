namespace Ecommerce.Domain.ExternalServices.Models
{
    public class SkuLojista
    {
        public bool? Eleito { get; set; }

        public Lojista Lojista { get; set; }

        public decimal? PrecoAnterior { get; set; }

        public decimal? PrecoVenda { get; set; }

        public bool? Fidelizado { get; set; }
    }
}
