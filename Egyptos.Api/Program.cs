using Egyptos.Api;
using Egyptos.Application;
using Egyptos.Application.Services.Implementations;
using Egyptos.Infrastructure;
using Hangfire;
using HangfireBasicAuthenticationFilter;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
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

////SignIn with Google
//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//    options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
//})
//.AddCookie()
//.AddGoogle(options =>
//{
//    options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//    options.ClientId = "568505331278-0k4m966hgq4pj8libjttu5ib58r6hhcl.apps.googleusercontent.com";
//    options.ClientSecret = "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";
//});



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
