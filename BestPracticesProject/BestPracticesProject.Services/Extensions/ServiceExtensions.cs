using BestPracticesProject.Services.Categories;
using BestPracticesProject.Services.ExceptionHandlers;
using BestPracticesProject.Services.Products;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BestPracticesProject.Services.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(cfg => cfg.AddMaps(Assembly.GetExecutingAssembly()));
            services.AddExceptionHandler<CriticalExceptionHandler>();
            services.AddExceptionHandler<GlobalExceptionHandler>();

            return services;
        }
    }
}
