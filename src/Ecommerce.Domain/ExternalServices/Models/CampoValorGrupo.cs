namespace Ecommerce.Domain.ExternalServices.Models
{
    public class CampoValorGrupo
    {
        public int IdCampoValorGrupo { get; set; }

        public string Nome { get; set; }

        public CampoValor[] Especificacoes { get; set; }
    }
}
