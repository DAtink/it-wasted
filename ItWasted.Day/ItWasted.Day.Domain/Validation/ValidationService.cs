using ItWasted.Day.Domain.Entities;
using System;
using System.Linq;

namespace ItWasted.Day.Domain.Validation
{
  public class ValidationService : IValidationService
  {
    public ValidationResult ValidateWastesPack(WastesPack wastesPack)
    {
      if (wastesPack is null)
      {
        return ValidationResult.CreateInvalid(new[] { "WastesPack can not be null" });
      }

      if (string.IsNullOrWhiteSpace(wastesPack.Store))
      {
        return ValidationResult.CreateInvalid(new[] { "Store can not be null or empty" });
      }

      if (!wastesPack.Wastes.Any())
      {
        return ValidationResult.CreateInvalid(new[] { "At least one Waste should be in WastesPack" });
      }

      return ValidationResult.CreateValid();
    }
  }
}
