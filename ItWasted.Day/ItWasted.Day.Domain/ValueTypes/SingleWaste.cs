using System;

namespace ItWasted.Day.Domain.ValueTypes
{
  public class SingleWaste
  {
    public double Size { get; protected set; }

    public int Type { get; protected set; }

    public string Title { get; protected set; }

    public DateTime Timestamp { get; protected set; }

    protected SingleWaste() { }

    public SingleWaste Create(double size, int type, string title, DateTime timestamp)
    {
      return new SingleWaste()
      {
        Size = size,
        Type = type,
        Title = title,
        Timestamp = timestamp
      };
    }
  }
}
