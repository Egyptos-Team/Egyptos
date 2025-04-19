using Egyptos.Api;
using Egyptos.Application;
using Egyptos.Application.Services.Implementations;
using Egyptos.Infrastructure;
using Hangfire;
using HangfireBasicAuthenticationFilter;
using Scalar.AspNetCore;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddHttpClient<ChatMessageService>();

StripeConfiguration.ApiKey = builder.Configuration["Stripe:SecretKey"];

builder.Services
    .AddApiExtensions(builder.Configuration)
    .AddApplicationExtensions(builder.Configuration)
    .AddInfrastructureExtensions(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.MapOpenApi();
app.MapScalarApiReference();

app.UseHangfireDashboard("/jobs", new DashboardOptions()
{
    Authorization =
    [
        new HangfireCustomBasicAuthenticationFilter
        {
            User  = app.Configuration.GetValue<string>("HangfireSettings:Username"),
            Pass  = app.Configuration.GetValue<string>("HangfireSettings:Password")
        }
    ],
    DashboardTitle = "Egyptos Dashboard",
    // IsReadOnlyFunc = (DashboardContext context) => true

});
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
