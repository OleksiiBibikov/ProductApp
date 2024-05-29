namespace ProductApp.Migrations
{
    public static class ProgramExtensions
    {
        public static WebApplicationBuilder ConfigureAppSettings(this WebApplicationBuilder builder, string basePath)
        {
            builder.Configuration.SetBasePath(basePath);
            return builder;
        }
    }
}
