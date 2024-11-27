using CEM.Components;
using Microsoft.EntityFrameworkCore;
using CEM.Models;
using Radzen;


using System.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Minio;
using Blazored.Toast;


        var builder = WebApplication.CreateBuilder(args);

        IConfigurationRoot configuration = new ConfigurationBuilder()
                                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                .AddJsonFile("appsettings.json")
                                .Build();

        builder.Services.AddDbContext<CEMContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));





        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.Cookie.Name = "auth_token";
                options.LoginPath = "/login";
                options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
                options.AccessDeniedPath = "/access_denied";
            });






        builder.Services.AddBlazoredToast();
        builder.Services.AddHttpClient("MinioClient", client =>
        {
            client.BaseAddress = new Uri("http://localhost:9000"); // Thay th? b?ng URL MinIO c?a b?n
        });




builder.Services.AddSingleton<FileService>();


// Add services to the container.
builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();
        builder.Services.AddRadzenComponents();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddRazorPages();
        builder.Services.AddRadzenCookieThemeService();
        builder.Services.AddScoped<DialogService>();
        builder.Services.AddScoped<NotificationService>();
        builder.Services.AddAuthorization();
        builder.Services.AddCascadingAuthenticationState();
        builder.Services.AddHttpContextAccessor();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapBlazorHub();
        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
      