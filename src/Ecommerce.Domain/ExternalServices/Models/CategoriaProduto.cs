namespace Ecommerce.Domain.ExternalServices.Models
{
    public class CategoriaProduto
    {
        public int IdCategoria { get; set; }

        public string Nome { get; set; }

        public CategoriaProduto Categoria { get; set; }
    }
}
