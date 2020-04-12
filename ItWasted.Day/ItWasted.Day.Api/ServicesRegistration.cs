using ItWasted.Day.Domain.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace ItWasted.Day.Api
{
  public static class ServicesRegistration
  {
    public static void RegieterDomainServices(IServiceCollection services)
    {
      services.AddSingleton<IValidationService, ValidationService>();
    }
  }
}
