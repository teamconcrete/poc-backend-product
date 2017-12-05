using Ecommerce.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Web.Requests
{
    public class ProductRequest : BaseRequest<Product>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public override Product ConvertToModel()
        {
            var product = new Product()
            {
                Name = Name,
                Description = Description,
                ImageUrl = ImageUrl
            };

            return product;
        }
    }
}
