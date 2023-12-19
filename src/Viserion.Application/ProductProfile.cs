using AutoMapper;
using Viserion.Domain;

namespace Viserion.Application;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<ProductDto, Product>();
        CreateMap<Product, ProductDto>();
    }
}