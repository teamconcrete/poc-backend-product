using Ecommerce.Api.Requests;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : BaseController
    {
        IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;               
        }

        [HttpGet()]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(string id)
        {
            var idInt = int.Parse(id);

            return await _service.GetByIdAsync(idInt);
        }

        [HttpGet("sku/{sku}")]
        public async Task<Product> GetBySku(string sku)
        {
            var skuInt = int.Parse(sku);

            return await _service.GetBySkuAsync(skuInt);
        }        
    }
}
