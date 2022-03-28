using System;
using System.ComponentModel.DataAnnotations;

namespace test.Data.Validate
{
    public class AttendanceValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var CheckOut = (TimeSpan)value;
            var CheckIn = (TimeSpan)validationContext.ObjectType.GetProperty("CheckIn")?.GetValue(validationContext.ObjectInstance, null);
            
            return CheckOut > CheckIn ? new ValidationResult(ErrorMessage = "Cant be before the Check In") : ValidationResult.Success;
        }
    }
}
