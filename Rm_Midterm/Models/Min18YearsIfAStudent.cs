using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rm_Midterm.Models
{
    public class Min18YearsIfAStudent : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var student = (Students)validationContext.ObjectInstance;

            if (student.BirthDate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - student.BirthDate.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Students must be 18 years or older to be enrolled");
        }
    }
}