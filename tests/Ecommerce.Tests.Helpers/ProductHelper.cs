using System;
using System.Collections.Generic;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.ExternalServices.Models;

namespace Ecommerce.Tests.Helpers
{
    public static class ProductHelper
    {
        public static IEnumerable<Product> GenerateProducts(int quantity)
        {
            var random = new Random();

            for (var i = 0; i < quantity; i++)
            {
                yield return new Product()
                {
                    Id = random.Next(10000),
                    Description = $"Details of the product {quantity}",
                    Name = $"Product {quantity}",
                    ImageUrl = "http://cdn.test.com/images/123"
                };
            }
        }

        public static IEnumerable<Produto> GenerateExternalProdutos(int quantity)
        {
            var random = new Random();

            for (var i = 0; i < quantity; i++)
            {
                yield return new Produto()
                {
                    IdProduto = random.Next(10000),
                    Descricao = $"Details of the product {quantity}",
                    Nome = $"Product {quantity}",
                    Imagens = new Imagem[] {
                        new Imagem() {
                            Url = "http://cdn.test.com/images/123"
                        }
                    } 
                };
            }
        }
    }
}
