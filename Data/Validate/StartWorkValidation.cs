using System;
using System.ComponentModel.DataAnnotations;

namespace test.Data.Validate
{
    public class StartWorkValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToDateTime(value).Day==DateTime.Now.Day&& Convert.ToDateTime(value).Month == DateTime.Now.Month&& Convert.ToDateTime(value).Year == DateTime.Now.Year)
            {
                return ValidationResult.Success;
            }
            return  new ValidationResult("Must Join Today") ;
        }
    }
}
