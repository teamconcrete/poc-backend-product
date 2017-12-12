namespace Ecommerce.Domain.ExternalServices.Models
{
    public class Marca
    {
        public int IdMarca { get; set; }

        public string Nome { get; set; }

        public string TextoLink { get; set; }

        public string Texto { get; set; }

        public string PalavraChave { get; set; }

        public string TituloSite { get; set; }

        public bool? FlagAtiva { get; set; }

        public string Contatos { get; set; }

        public string LinkChat { get; set; }

        public string Telefone { get; set; }

        public string EmailSite { get; set; }

        public string ObservacaoSac { get; set; }

        public bool? FlagExibirContato { get; set; }
    }
}
