using ItWasted.Day.Api.Db;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace ItWasted.Day.Api
{
  class Program
  {
    static void Main(string[] args)
    {
      var host = CreateHostBuilder(args).Build();

      InitializeDb(host);

      host.Start();
    }

    private static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
          webBuilder.UseStartup<Startup>();
        });

    private static void InitializeDb(IHost host)
    {
      using var scope = host.Services.CreateScope();
      var services = scope.ServiceProvider;

      try
      {
        var context = services.GetRequiredService<ItWastedDbContext>();
        context.Database.EnsureCreated();
      }
      catch (Exception ex)
      {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
      }
    }
  }
}
