using ItWasted.Day.Domain.ValueTypes;
using System;
using System.Collections.Generic;

namespace ItWasted.Day.Domain.Entities
{
  public class WastedPerDay
  {
    public DateTime Day { get; protected set; }

    public IList<SingleWaste> Wastes { get; protected set; }

    public string AdditionalInfo { get; protected set; }

    protected WastedPerDay() { }

    public void AddWaste(SingleWaste waste)
    {
      Wastes.Add(waste);
    }

    public WastedPerDay Create(DateTime day, IList<SingleWaste> wastes, string additionalInfo)
    {
      return new WastedPerDay()
      {
        Day = day,
        Wastes = wastes,
        AdditionalInfo = additionalInfo
      };
    }
  }
}
