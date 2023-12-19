using Microsoft.Extensions.DependencyInjection;

namespace Viserion.Application;

public static class ApplicationExtensions
{
    public static IServiceCollection AddProductService(this IServiceCollection services)
    {
        services.AddTransient<IProductService, ProductService>();

        return services;
    }
}