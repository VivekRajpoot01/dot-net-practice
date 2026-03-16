using ProductManagementDemo.API.DTOs;

namespace ProductManagementDemo.API.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductDetailDto> GetProductByIdAsync(int id);

        Task<PagedResultDto<ProductSummaryDto>> GetAllProductsAsync(ProductFilterDto filter, int page, int size);

        Task<ProductDetailDto> CreateProductAsync(CreateProductDto dto);

        Task<ProductDetailDto> UpdateProductAsync(int id, UpdateProductDto dto);

        Task<bool> DeleteProductAsync(int id);
    }
}
