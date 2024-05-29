using Microsoft.Extensions.DependencyInjection;
using ProductApp.Infrastructure.Repositories;
using ProductApp.Infrastructure.Abstract;
using ProductApp.Services.Services;
using ProductApp.Services.Abstract;

namespace ProductApp.HttpAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProductServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
