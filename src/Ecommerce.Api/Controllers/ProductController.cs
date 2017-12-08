using AutoMapper;
using Ecommerce.Api.Requests;
using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : BaseController
    {
        IProductAppService _service;

        public ProductController(IProductAppService service)
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
            var guid = Guid.Parse(id);

            return await _service.GetAsync(guid);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ProductRequest value)
        {
            var product = Mapper.Map<ProductRequest, Product>(value);

            await _service.CreateAsync(product);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody]ProductRequest value)
        {
            var guid = Guid.Parse(id);
            var product = Mapper.Map<ProductRequest, Product>(value);
            product.Id = guid;

            var exists = await _service.GetAsync(guid);

            if (exists == null)
                return NotFound();

            await _service.UpdateAsync(product);

            return Ok();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var guid = Guid.Parse(id);

            var product = await _service.GetAsync(guid);

            if (product == null)
                return NotFound();

            await _service.DeleteAsync(product);

            return Ok();
        }
    }
}
