using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ItWasted.Day.Api
{
  class Program
  {
    static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Start();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
          webBuilder.UseStartup<Startup>();
        });
  }
}
