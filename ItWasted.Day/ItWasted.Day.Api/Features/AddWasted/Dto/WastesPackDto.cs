using System.Collections.Generic;

namespace ItWasted.Day.Api.Features.AddWasted.Dto
{
  public class WastesPackDto
  {
    public IReadOnlyCollection<SingleWasteDto> Wastes { get; set; }

    public string AdditionalInfo { get; set; }

    public string Store { get; set; }
  }
}
