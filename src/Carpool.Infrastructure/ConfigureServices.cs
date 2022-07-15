using Carpool.Application.Common.Interfaces;
using Carpool.Infrastructure.Persistance;
using Carpool.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Carpool.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseNpgsql(configuration.GetSection("ConnectionStrings:DefaultConnection").Value));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

            services.AddScoped<ApplicationDbContextInitialiser>();

            services.AddTransient<IDateTime, DateTimeService>();

            return services;
        }
    }
}
