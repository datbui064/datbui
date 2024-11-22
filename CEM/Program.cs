using CEM.Components;
using Microsoft.EntityFrameworkCore;
using CEM.Models;
using Radzen;
using CEM.Data;

var builder = WebApplication.CreateBuilder(args);

IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json")
                        .Build();
<<<<<<< HEAD
builder.Services.AddDbContext<CEMContext>(options => options.UseSqlServer(configuration.GetConnectionString("DBConnection"), p => p.EnableRetryOnFailure()), ServiceLifetime.Transient);
=======
builder.Services.AddDbContext<dbQLBContext>(options => options.UseSqlServer(configuration.GetConnectionString("DBConnection"), p => p.EnableRetryOnFailure()), ServiceLifetime.Transient);
builder.Services.AddDbContext<QlbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("QLB"), p => p.EnableRetryOnFailure()));


>>>>>>> e6ffa14f78348e22e200b856db44922a96e4e891

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddRadzenComponents();
builder.Services.AddServerSideBlazor();
builder.Services.AddRazorPages();
builder.Services.AddRadzenCookieThemeService();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
