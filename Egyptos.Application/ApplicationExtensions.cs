namespace Egyptos.Application;
using Microsoft.Extensions.DependencyInjection;

public static class ApplicationExtensions
{
    public static IServiceCollection AddApplicationExtensions(this IServiceCollection services)
    {
        services
            .AddEgyptosServices();



        return services;
    }

    private static IServiceCollection AddEgyptosServices(this IServiceCollection services)
    {
        // add scoped services
        return services;
    }
}
