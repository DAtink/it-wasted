using System.Collections.Generic;

namespace ItWasted.Day.Domain.Validation
{
  public class ValidationResult
  {
    public bool IsValid { get; private set; }
    public IReadOnlyCollection<string> Errors { get; private set; }

    private ValidationResult() { }

    public static ValidationResult CreateValid()
    {
      return new ValidationResult
      {
        IsValid = true,
      };
    }

    public static ValidationResult CreateInvalid(IReadOnlyCollection<string> errors)
    {
      return new ValidationResult
      {
        IsValid = false,
        Errors = errors
      };
    }
  }
}