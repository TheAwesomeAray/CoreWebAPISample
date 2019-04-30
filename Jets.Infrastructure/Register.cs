using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Jets.Infrastructure
{
    public static class Register
    {
        public static IServiceCollection AddJetsServices(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddJetsTestServices(this IServiceCollection services)
        {
            services.AddDbContext<JetsTestContext>(options =>
            {
                options.UseInMemoryDatabase("InMemoryDatabaseForTesting");
            });

            services.AddScoped<IJetsDataAccess, JetsTestContext>();

            return services;
        }
    }
}
