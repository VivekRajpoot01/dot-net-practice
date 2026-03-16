using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductManagementDemo.API.Data;
using ProductManagementDemo.API.DTOs;
using ProductManagementDemo.API.Entities;
using ProductManagementDemo.API.Services.Interfaces;
namespace ProductManagementDemo.API.Services.Implementations
{
    public class ProductService: IProductService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductDetailDto> GetProductByIdAsync(int id)
        {
            var product = await _context.Products
                .Include(x => x.Category)
                .Include(x => x.Inventory)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (product == null)
                throw new KeyNotFoundException("Product not found");

            return _mapper.Map<ProductDetailDto>(product);
        }

        public async Task<PagedResultDto<ProductSummaryDto>> GetAllProductsAsync(ProductFilterDto filter, int page, int size)
        {
            var query = _context.Products
                .Include(x => x.Category)
                .Include(x => x.Inventory)
                .AsQueryable();

            var total = await query.CountAsync();

            var products = await query
                .Skip((page - 1) * size)
                .Take(size)
                .ToListAsync();

            return new PagedResultDto<ProductSummaryDto>
            {
                Items = _mapper.Map<List<ProductSummaryDto>>(products),
                TotalCount = total,
                PageNumber = page,
                PageSize = size,
                TotalPages = (int)Math.Ceiling(total / (double)size)
            };
        }

        public async Task<ProductDetailDto> CreateProductAsync(CreateProductDto dto)
        {
            var product = _mapper.Map<Product>(dto);

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return await GetProductByIdAsync(product.Id);
        }

        public async Task<ProductDetailDto> UpdateProductAsync(int id, UpdateProductDto dto)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                throw new KeyNotFoundException();

            if (dto.Name != null) product.Name = dto.Name;
            if (dto.Price != null) product.Price = dto.Price.Value;
            if (dto.DiscountedPrice != null) product.DiscountedPrice = dto.DiscountedPrice;

            await _context.SaveChangesAsync();

            return await GetProductByIdAsync(id);
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null) return false;

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
