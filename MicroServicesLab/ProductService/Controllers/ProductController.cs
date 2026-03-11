using Microsoft.AspNetCore.Mvc;
using ProductService.Dtos;
using ProductService.Models;
using ProductService.Repositories;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(
            IProductRepository repository,
            ILogger<ProductsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var products = await _repository.GetAllAsync();
            var productDtos = products.Select(MapToDto);
            return Ok(productDtos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProductDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
                return NotFound();

            return Ok(MapToDto(product));
        }

        [HttpGet("category/{categoryId}")]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProductsByCategory(int categoryId)
        {
            var products = await _repository.GetByCategoryAsync(categoryId);
            var productDtos = products.Select(MapToDto);
            return Ok(productDtos);

        }
        [HttpPost]
        [ProducesResponseType(typeof(ProductDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductDto>> CreateProduct(CreatedProductDto createDto)
        {
            try
            {
                var product = new Product
                {
                    Name = createDto.Name,
                    Description = createDto.Description,
                    Price = createDto.Price,
                    CategoryId = createDto.CategoryId,
                    CategoryName = GetCategoryName(createDto.CategoryId),
                    ImageUrl = createDto.ImageUrl,
                    AvailableStock = createDto.InitialStock
                };

                var created = await _repository.AddAsync(product);

                return CreatedAtAction(
                    nameof(GetProduct),
                    new { id = created.Id },
                    MapToDto(created));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating product");
                return BadRequest("Failed to create product");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProduct(int id, UpdateProductDto updateDto)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
                return NotFound();

            product.Name = updateDto.Name;
            product.Description = updateDto.Description;
            product.Price = updateDto.Price;
            product.AvailableStock = updateDto.AvailableStock;
            await _repository.UpdateAsync(product);
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (!await _repository.ExistsAsync(id))
                return NotFound();

            await _repository.DeleteAsync(id);
            return NoContent();
        }

        [HttpPut("{id}/stock")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateStock(int id, [FromBody] int quantity)
        {
            if (!await _repository.ExistsAsync(id))
                return NotFound();

            var success = await _repository.UpdateStockAsync(id, quantity);
            if (!success)
                return BadRequest("Insufficient stock");

            return Ok(new { message = "Stock updated successfully" });
        }

        private ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CategoryName = product.CategoryName,
                ImageUrl = product.ImageUrl,
                AvailableStock = product.AvailableStock
            };
        }

        private string GetCategoryName(int categoryId)
        {
            // In a real app, this might come from a category service or database
            return categoryId switch
            {
                1 => "Electronics",
                2 => "Home & Kitchen",
                3 => "Clothing",
                4 => "Books",
                _ => "Other"
            };
        }
    }
}

