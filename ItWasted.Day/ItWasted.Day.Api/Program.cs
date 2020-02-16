using Company.WebApi.Core.DefaultConfiguration;

namespace ItWasted.Day.Api
{
  class Program
  {
    static void Main(string[] args)
    {
      DefaultKestrelRunner
        .Configure().BuildWebHost(args).Start();
    }
  }
}
