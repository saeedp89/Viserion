namespace Viserion.Application;

public interface IProductService
{
    Task CreateProductAsync(ProductDto dto);
}