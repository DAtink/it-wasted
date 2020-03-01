using SimpleInjector;
using SimpleInjector.Packaging;
using ViennaNET.WebApi.Configurators.Diagnosing;

namespace ItWasted.Day.Api
{
  public class MainPackage : IPackage
  {
    public void RegisterServices(Container container)
    {
      var diagPackage = new DiagnosticPackage();
      diagPackage.RegisterServices(container);
    }
  }
}
