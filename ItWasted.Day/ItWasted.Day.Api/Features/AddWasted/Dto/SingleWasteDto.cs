using ItWasted.Day.Domain.ValueTypes;

namespace ItWasted.Day.Api.Features.AddWasted.Dto
{
  public class SingleWasteDto
  {
    public double Size { get; protected set; }

    public SizeTypes SizeType { get; protected set; }

    public int Type { get; protected set; }

    public string Title { get; protected set; }
  }
}
