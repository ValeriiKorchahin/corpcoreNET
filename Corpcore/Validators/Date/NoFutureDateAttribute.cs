using System.ComponentModel.DataAnnotations;

namespace Corpcore.Validators.Date
{
    public class NoFutureDateAttribute: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {

            if (value is DateOnly date)
            {
                return date <= DateOnly.FromDateTime(DateTime.UtcNow);
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} cannot be in the future.";
        }
    }
}
