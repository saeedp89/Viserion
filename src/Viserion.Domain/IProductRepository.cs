namespace Viserion.Domain;

public interface IProductRepository : IRepository<Product>
{
    Task AddProductAsync(Product product);
}