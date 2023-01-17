namespace EpiSvelte;

public class Program
{
    public static IConfiguration Configuration { get; } =
           new ConfigurationBuilder()
           .AddJsonFile("appSettings.json", false, true)
           .AddJsonFile($"appSettings.{Environment.MachineName}.json", true, true)                                                                                  .AddJsonFile($"appsettings.{Environment.MachineName}.json", true, true)
           .AddEnvironmentVariables()
           .Build();
    
    public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureCmsDefaults()
            .ConfigureAppConfiguration((ctx, builder) => builder.AddConfiguration(Configuration))
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
}
                                                     