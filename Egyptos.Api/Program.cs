using Egyptos.Api;
using Egyptos.Application;
using Egyptos.Infrastructure;
using Hangfire;
using HangfireBasicAuthenticationFilter;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services
    .AddApiExtensions(builder.Configuration)
    .AddApplicationExtensions(builder.Configuration)
    .AddInfrastructureExtensions(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

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
