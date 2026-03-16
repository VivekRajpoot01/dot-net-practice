using System.ComponentModel.DataAnnotations;

namespace ProductManagementDemo.API.DTOs
{
    public class ProductDetailDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public decimal? DiscountedPrice { get; set; }

        public decimal Savings => Price - (DiscountedPrice ?? Price);

        public CategoryBasicDto Category { get; set; } = new();

        public bool IsActive { get; set; }

        public bool IsFeatured { get; set; }

        public double AverageRating { get; set; }

        public int ReviewCount { get; set; }

        public string ImageUrl { get; set; } = "";

        public InventoryStatusDto? Inventory { get; set; }
    }

    public class ProductSummaryDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public decimal Price { get; set; }

        public decimal? DiscountedPrice { get; set; }

        public string CategoryName { get; set; } = "";

        public string ImageUrl { get; set; } = "";

        public bool IsInStock { get; set; }
    }

    public class CreateProductDto
    {
        [Required]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        [Required]
        public decimal Price { get; set; }

        public decimal? DiscountedPrice { get; set; }

        public int CategoryId { get; set; }

        public string Sku { get; set; } = "";

        public string ImageUrl { get; set; } = "";
    }

    public class UpdateProductDto
    {
        public string? Name { get; set; }

        public decimal? Price { get; set; }

        public decimal? DiscountedPrice { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsFeatured { get; set; }

        public string? ImageUrl { get; set; }
    }

    public class ProductFilterDto
    {
        public string? SearchTerm { get; set; }

        public int? CategoryId { get; set; }

        public decimal? MinPrice { get; set; }

        public decimal? MaxPrice { get; set; }

        public string? SortBy { get; set; }

        public bool SortDescending { get; set; }
    }

    public class PagedResultDto<T>
    {
        public List<T> Items { get; set; } = new();

        public int TotalCount { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int TotalPages { get; set; }

        public bool HasPrevious => PageNumber > 1;

        public bool HasNext => PageNumber < TotalPages;
    }
}
