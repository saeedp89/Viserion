using Viserion.Domain;

namespace Viserion.Infrastructure;

public class ProductRepository : IProductRepository
{
    private readonly ViserionDbContext _dbContext;

    public IUnitOfWork UnitOfWork => _dbContext;

    public ProductRepository(ViserionDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddProductAsync(Product product)
    {
        await _dbContext.Products.AddAsync(product);
    }
}