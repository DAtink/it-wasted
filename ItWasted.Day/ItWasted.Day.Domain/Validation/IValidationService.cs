using ItWasted.Day.Domain.Entities;

namespace ItWasted.Day.Domain.Validation
{
  public interface IValidationService
  {
    ValidationResult ValidateWastesPack(WastesPack wastesPack);
  }
}
