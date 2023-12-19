using AutoMapper;
using Viserion.Domain;

namespace Viserion.Application;

public class ProductService:IProductService
{
    private readonly IProductRepository _productRepository;

    private readonly IMapper _mapper;
    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task CreateProductAsync(ProductDto dto)
    {
        var model = _mapper.Map<Product>(dto);
        await _productRepository.AddProductAsync(model);
        await _productRepository.UnitOfWork.SaveEntitiesAsync();
    }
}