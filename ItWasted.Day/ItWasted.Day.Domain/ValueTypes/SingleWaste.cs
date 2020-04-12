using System;

namespace ItWasted.Day.Domain.ValueTypes
{
  public class SingleWaste
  {
    public double Size { get; private set; }
    public SizeTypes SizeType { get; private set; }

    public int Type { get; private set; }

    public string Title { get; private set; }

    public DateTime Timestamp { get; private set; }

    protected SingleWaste() { }

    public SingleWaste Create(double size, int type, string title)
    {
      return new SingleWaste()
      {
        Size = size,
        Type = type,
        Title = title,
        Timestamp = DateTime.UtcNow
      };
    }
  }
}
