using ItWasted.Day.Api.Db;
using ItWasted.Day.Api.Features.AddNewWaste.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ItWasted.Day.Api
{
  public static class ServicesRegistration
  {
    public static void RegisterDomainServices(IServiceCollection services, IConfiguration configuration)
    {
      services.AddSingleton<IAddNewWasteService, AddNewWasteService>();

      services.AddDbContext<ItWastedDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("ItWastedDbContext")));
    }
  }
}
