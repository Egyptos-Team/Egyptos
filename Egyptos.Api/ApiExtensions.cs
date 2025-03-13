using Egyptos.Api.OpenApiTransformers;
using Egyptos.Domain.Interfaces;
using Egyptos.Infrastructure.Services;

namespace Egyptos.Api;

public static class ApiExtensions
{
    public static IServiceCollection AddApiExtensions(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddCorsConfig(configuration)
            .AddOpenApiServices();

        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Templates");
        services.AddSingleton<ITemplateReader>(new FileTemplateReader(templatePath));

        return services;
    }


    private static IServiceCollection AddOpenApiServices(this IServiceCollection services)
    {
        var serviceProvider = services.BuildServiceProvider();

        services.AddOpenApi(options =>
        {
            options.AddDocumentTransformer<BearerSecuritySchemeTransformer>();
        });

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
