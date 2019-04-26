using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebAPISample;

namespace FunctionalTests
{
    public class CustomWebApplicationFactory<TStartup>
    : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                //services.AddEntityFrameworkInMemoryDatabase();

                // Create a new service provider.
                //var provider = services
                //    .AddEntityFrameworkInMemoryDatabase()
                //    .BuildServiceProvider();

                // Add a database context (ApplicationDbContext) using an in-memory 
                // database for testing.
                //services.AddDbContext<CatalogContext>(options =>
                //{
                //    options.UseInMemoryDatabase("InMemoryDbForTesting");
                //    options.UseInternalServiceProvider(provider);
                //});

                //services.AddDbContext<AppIdentityDbContext>(options =>
                //{
                //    options.UseInMemoryDatabase("Identity");
                //    options.UseInternalServiceProvider(provider);
                //});

                //services.AddIdentity<ApplicationUser, IdentityRole>()
                //        .AddDefaultUI(UIFramework.Bootstrap4)
                //        .AddEntityFrameworkStores<AppIdentityDbContext>()
                //        .AddDefaultTokenProviders();

                // Build the service provider.
                var sp = services.BuildServiceProvider();

                // Create a scope to obtain a reference to the database
                // context (ApplicationDbContext).
                
            });
        }
    }
}
