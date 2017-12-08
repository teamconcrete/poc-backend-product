using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Api.Requests
{
    public class ProductRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }        
    }
}
