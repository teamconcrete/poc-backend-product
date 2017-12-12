namespace Ecommerce.Domain.ExternalServices.Models
{
    public class Lojista
    {
        public int IdLojista { get; set; }

        public string Nome { get; set; }

        public bool RetiraEmLojaParceiro { get; set; }

        public bool LojistaInternacional { get; set; }
    }
}
