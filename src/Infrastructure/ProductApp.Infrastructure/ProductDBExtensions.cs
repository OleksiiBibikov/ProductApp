using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Data;
using ProductApp.Infrastructure.Repositories;
using ProductApp.Shared.Abstract;

namespace ProductApp.Infrastructure
{
    public static class ProductDBExtensions
    {
        public static WebApplicationBuilder ConfigureSQLServer(this WebApplicationBuilder builder,
            string migrationAssemblyName)
        {
            var dbOptions = builder.Configuration.GetSection("ConnectionStrings").Get<DBContextSettings>();

            builder.Services.AddDbContext<ProductDBContext>(options =>
            options.UseSqlServer(dbOptions.ProductDbConnectionString ?? dbOptions.DefaultConnection,
            x => x.MigrationsAssembly(migrationAssemblyName)));

            builder.Services.AddTransient<IRepository<Product>, ProductRepository>();
            builder.Services.AddTransient<IRepository<Provider>, ProviderRepository>();

            return builder;
        }
    }
}
