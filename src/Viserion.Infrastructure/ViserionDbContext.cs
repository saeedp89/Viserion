using Microsoft.EntityFrameworkCore;
using Viserion.Domain;

namespace Viserion.Infrastructure;

public class ViserionDbContext : DbContext, IUnitOfWork
{
    public ViserionDbContext(DbContextOptions<ViserionDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
    {
        return await SaveChangesAsync(cancellationToken) > 1;
    }
}