using AutoMapper;
using ProductManagementDemo.API.DTOs;
using ProductManagementDemo.API.Entities;

namespace ProductManagementDemo.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProductDto, Product>()
                .ForMember(dest => dest.SKU, opt => opt.MapFrom(src => src.Sku))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow));

            CreateMap<Product, ProductSummaryDto>()
                .ForMember(dest => dest.CategoryName,
                    opt => opt.MapFrom(src => src.Category!.Name))
                .ForMember(dest => dest.IsInStock,
                    opt => opt.MapFrom(src => src.Inventory!.Quantity > 0));

            CreateMap<Product, ProductDetailDto>();

            CreateMap<Category, CategoryBasicDto>();
        }
    }
}
