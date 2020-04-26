using System;

namespace ItWasted.Day.Domain.Entities
{
  public class Waste
  {
    public int Id { get; set; }

    public int Category { get; private set; }

    public string Title { get; private set; }

    public decimal Price { get; protected set; }

    public DateTime Timestamp { get; private set; }

    protected Waste() { }

    public static Waste Create(int category, string title, decimal price)
    {
      return new Waste()
      {
        Category = category,
        Title = title,
        Price = price,
        Timestamp = DateTime.UtcNow
      };
    }
  }
}
