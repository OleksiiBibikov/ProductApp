using ProductApp.Infrastructure;

namespace ProductApp.Migrations
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var assemblyName = typeof(Program).Assembly.GetName().Name;

            var builder = WebApplication.CreateBuilder(args)
                .ConfigureAppSettings(Directory.GetCurrentDirectory())
                .ConfigureSQLServer(assemblyName);

            var app = builder.Build();

            await app.RunAsync();
        }
    }
}
