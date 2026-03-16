using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagementDemo.API.DTOs;
using ProductManagementDemo.API.Services.Interfaces;

namespace ProductManagementDemo.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] ProductFilterDto filter, int pageNumber = 1, int pageSize = 10)
        {
            return Ok(await _service.GetAllProductsAsync(filter, pageNumber, pageSize));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await _service.GetProductByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateProductDto dto)
        {
            var product = await _service.CreateProductAsync(dto);

            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateProductDto dto)
        {
            return Ok(await _service.UpdateProductAsync(id, dto));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteProductAsync(id);

            if (!deleted) return NotFound();

            return NoContent();
        }
    }
}
