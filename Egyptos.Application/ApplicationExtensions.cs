using System.Reflection;
using Egyptos.Application.Settings;
using Hangfire;
using MapsterMapper;
using Egyptos.Application.Services.Implementations;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Egyptos.Application;
public static class ApplicationExtensions
{
    public static IServiceCollection AddApplicationExtensions(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddEgyptosServices()
            .AddAuthConfig(configuration)
            .AddMapsterServices()
            .AddBackgroundJobsConfig(configuration)
            .AddEmailSenderConfiguration().
            AddFluentValidationConfig();



        return services;
    }
    private static IServiceCollection AddFluentValidationConfig(this IServiceCollection services)
    {
        services
            .AddFluentValidationAutoValidation()
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
    private static IServiceCollection AddEgyptosServices(this IServiceCollection services)
    {
        // add scoped services
        services.AddScoped<IFileService, FileService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IPrivateTransportService, PrivateTransportService>();
        services.AddScoped<ITransportTypeService, TransportTypeService>();
        services.AddScoped<IEventTypeService, EventTypeService>();
        services.AddScoped<IEventService, EventService>();
        services.AddScoped<IEventDateService, EventDateService>();
        services.AddScoped<IEventImageService, EventImageService>();
        services.AddScoped<IBookingEventDateService, BookingEventDateService>();
        services.AddScoped<IBookingPrivateTransportService, BookingPrivateTransportService>();
        services.AddScoped<IHotelService, HotelService>();
        services.AddScoped<ITourGuideServices, TourGuideServices>();
        services.AddScoped<IBookingTourGuideService, BookingTourGuideService>();
        services.AddScoped<ITourGuideReviewService, TourGuideReviewService>();
        services.AddScoped<IHistoricalService, HistoricalService>();
        services.AddScoped<IHistoricalImageService, HistoricalImageService>();
        services.AddScoped<IAreaTypeService, AreaTypeService>();
        services.AddScoped<IPayment, Payment>();
        services.AddScoped<IAreaService, AreaService>();
        services.AddScoped<IPrivateTransportReviewService, PrivateTransportReviewService>();
        services.AddScoped<IWorkingService, WorkingService>();
        services.AddScoped<IAreaWorkingService, AreaWorkingService>();
        services.AddScoped<IItemsService, ItemsService>();
        services.AddScoped<IChatMessageService, ChatMessageService>();
        services.AddScoped<ITripReviewService,TripReviewService>();
        services.AddScoped<IBookingTripService, BookingTripService>();


        services.AddHttpContextAccessor();

        return services;
    }
    private static IServiceCollection AddAuthConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

        services.AddScoped<IAuthService, AuthService>();
        services.AddSingleton<IJwtProvider, JwtProvider>();

        services.AddOptions<JwtOptions>()
            .BindConfiguration(JwtOptions.SectionName)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        var jwtSettings = configuration.GetSection(JwtOptions.SectionName).Get<JwtOptions>();

        services.AddAuthentication(options =>
        {
            // For [Authorize] know That We Use Bearer
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(o =>
        {
            o.SaveToken = true;
            o.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,

                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings!.Key!)),
                ValidIssuer = jwtSettings.Issuer,
                ValidAudience = jwtSettings.Audience,
            };

        });


        services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequiredLength = 8;
            options.SignIn.RequireConfirmedEmail = true;
            options.User.RequireUniqueEmail = true;
        });

        return services;
    }
    private static IServiceCollection AddMapsterServices(this IServiceCollection services)
    {
        var mappingConfig = TypeAdapterConfig.GlobalSettings;
        mappingConfig.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton<IMapper>(new Mapper(mappingConfig));


        return services;
    }
    private static IServiceCollection AddBackgroundJobsConfig(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddHangfire(config => config
            .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UseSqlServerStorage(configuration.GetConnectionString("DefaultConnection"), new Hangfire.SqlServer.SqlServerStorageOptions
            {
                SchemaName = "HangfireSchema"
            }));

        services.AddHangfireServer();

        return services;
    }
    private static IServiceCollection AddEmailSenderConfiguration(this IServiceCollection services)
    {
        services.AddSingleton<IEmailSender, EmailService>();
        services.AddOptions<MailSettings>()
            .BindConfiguration(nameof(MailSettings))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        return services;
    }
}
