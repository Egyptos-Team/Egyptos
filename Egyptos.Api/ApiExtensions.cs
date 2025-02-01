using Egyptos.Domain.Entities.Identity;
using Egyptos.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;

namespace Egyptos.Api;

public static class ApiExtensions
{
    public static IServiceCollection AddApiExtensions(this IServiceCollection services,IConfiguration configuration)
    {
        services
            .AddAuthConfig(configuration)
            .AddCorsConfig(configuration);



        return services;
    }

    private static IServiceCollection AddAuthConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

        return services;
    }

    private static IServiceCollection AddCorsConfig(this IServiceCollection services, IConfiguration configuration)
    {
        var allowedOrigin = configuration.GetSection("AllowedOrigin").Get<string[]>();
        services.AddCors(options =>
        {
            options.AddPolicy("MyPolicy", builder =>
            {
                builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowAnyOrigin();
            });
        });


        return services;
    }
}
