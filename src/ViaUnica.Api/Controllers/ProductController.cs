using ViaUnica.Application.Interfaces;
using ViaUnica.Domain.Entities;
using ViaUnica.Domain.Web.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ViaUnica.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
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
            var product = value.ConvertToModel();

            await _service.CreateAsync(product);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody]ProductRequest value)
        {
            var guid = Guid.Parse(id);
            var entity = value.ConvertToModel();
            entity.Id = guid;

            var exists = await _service.GetAsync(guid);

            if (exists == null)
                return NotFound();

            await _service.UpdateAsync(entity);

            return Ok();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var guid = Guid.Parse(id);

            var entity = await _service.GetAsync(guid);

            if (entity == null)
                return NotFound();

            await _service.DeleteAsync(entity);

            return Ok();
        }
    }
}
