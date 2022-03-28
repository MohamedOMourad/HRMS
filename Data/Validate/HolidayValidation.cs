using System;
using System.ComponentModel.DataAnnotations;

namespace test.Data.Validate
{
    public class HolidayValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToDateTime(value).Year == DateTime.Now.Year)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Only For this Year");
        }
    }
}
