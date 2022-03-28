using System;
using System.ComponentModel.DataAnnotations;

namespace test.Data.Validate
{
    public class DateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
 
            return DateTime.Now.Year -  Convert.ToDateTime(value).Year < 21 ? new ValidationResult("Cant be younger than 21 years old.") : ValidationResult.Success;
        }
    }
}
