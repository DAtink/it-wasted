using System;
using ViennaNET.WebApi.Runners.BaseKestrel;

namespace ItWasted.Day.Api
{
  class Program
  {
    static void Main(string[] args)
    {
      BaseKestrelRunner.Configure().BuildWebHost(args).Start();
      Console.ReadKey();
    }
  }
}
