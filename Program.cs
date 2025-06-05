using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WebApplication1.Application;
using WebApplication1.Repository;
namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Startup.InitiateStartup(args);

            // Add services to the container.

           
             CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
