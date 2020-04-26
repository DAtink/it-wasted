using ItWasted.Day.Api.Features.AddNewWaste.Dto;
using ItWasted.Day.Domain.Entities;

namespace ItWasted.Day.Api.Features.AddNewWaste.Mappers
{
  internal static class WasteDtoMapperExtensions
  {
    internal static Waste MapToEntity(this WasteDto dto)
    {
      return Waste.Create(dto.Category, dto.Title, dto.Price);
    }
  }
}
