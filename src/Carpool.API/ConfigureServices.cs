using Carpool.API.Filters;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;

namespace Carpool.API
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Carpool API", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyMethod()
                    );
            });

            services.AddControllers(options =>
             {
                 options.Filters.Add(new ApiExceptionFilterAttribute());
             })
             .AddFluentValidation(x => x.AutomaticValidationEnabled = false);

            return services;
        }

    }
}
