using ItWasted.Day.Domain.ValueTypes;
using System;
using System.Collections.Generic;

namespace ItWasted.Day.Domain.Entities
{
  public class WastesPack
  {
    public DateTime Timestamp { get; private set; }

    public IReadOnlyCollection<SingleWaste> Wastes { get; private set; }

    public string AdditionalInfo { get; private set; }

    public string Store { get; private set; }

    protected WastesPack() { }

    public WastesPack Create(IReadOnlyCollection<SingleWaste> wastes, string additionalInfo)
    {
      return new WastesPack()
      {
        Timestamp = DateTime.UtcNow,
        Wastes = wastes,
        AdditionalInfo = additionalInfo
      };
    }
  }
}
