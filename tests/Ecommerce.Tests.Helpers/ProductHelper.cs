using System;
using System.Collections.Generic;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Tests.Helpers
{
    public static class ProductHelper
    {
        public static IEnumerable<Product> GenerateProducts(int quantity)
        {
            for(var i = 0; i <quantity; i++)
            {
                yield return new Product()
                {
                    Id = Guid.NewGuid(),
                    Description = $"Details of the product {quantity}",
                    Name = $"Product {quantity}",
                    ImageUrl = "http://cdn.test.com/images/123",
                    LastModified = DateTime.Now
                };
            }
        }
    }
}
