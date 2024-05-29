
using ProductApp.HttpAPI.Extensions;
using ProductApp.Infrastructure.Abstract;
using ProductApp.Infrastructure.Repositories;

namespace ProductApp.HttpAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication
                .CreateBuilder(args)
                .ConfigureBuilder();

            var app = builder
                .Build()
                .ConfigureApplication();

            


            app.Run();
        }
    }
}
