

using SampleApi.Controllers.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;



public class SalutationCheckAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {


        var objExmaContext = validationContext.GetService(typeof(ExamContext2)) as ExamContext2;

        var title = objExmaContext.Isyslookupparam.Where(x => x.LookupCode.Equals("NBTitle")).ToList();

        if (value != null)
        {
            string Salutaion = value.ToString();
            if (title.Where(x => x.ParamValue.Equals(Salutaion, StringComparison.OrdinalIgnoreCase)).Count() == 0)
            {
                return new ValidationResult("Invalid Salutaion");

            }
        }
        // Return success if value is null or matches the allowed values
        return ValidationResult.Success;
        
    }
}
public class CustomGenderValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var objExmaContext = validationContext.GetService(typeof(ExamContext2)) as ExamContext2;

        //Accessing Database Context:
        var gender = objExmaContext.Isyslookupparam.Where(x => x.LookupCode.Equals("Gender")).ToList();
        if (value != null)
        {
            string gen = value.ToString();
            if (gender.Where(x => x.ParamValue.Equals(gen, StringComparison.OrdinalIgnoreCase)).Count() == 0)
            {
                return new ValidationResult("Invalid gender. Allowed values are Male,Female,Others.");

            }
        }
        // Return success if value is null or matches the allowed values
        return ValidationResult.Success;
    }
}


public class CategoryValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var objExmaContext = validationContext.GetService(typeof(ExamContext2)) as ExamContext2;

        var title = objExmaContext.Isyslookupparam.Where(x => x.LookupCode.Equals("NBTitle")).ToList();

        if (value != null)
        {
            string gender = value.ToString();
            if (title.Where(x => x.ParamValue.Equals(gender, StringComparison.OrdinalIgnoreCase)).Count() == 0)
            {
                return new ValidationResult("Invalid gender. Allowed values are Male, Female, or Other.");

            }
        }
        // Return success if value is null or matches the allowed values
        return ValidationResult.Success;
        // Return success if value is null or matches the allowed values
     
    }
}

public class AreaValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value != null)
        {
            string area = value.ToString();
            // Add custom validation logic here
            string[] allowedAreas = { "Rural", "Urban" };
            if (!allowedAreas.Contains(area))
            {
                return new ValidationResult("Invalid area. Allowed values are Rural or Urban.");
            }
        }
        // Return success if value is null or matches the allowed values
        return ValidationResult.Success;
    }
}

public class AllowWhatsAppMessageValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value != null)
        {
            string allowWhatsAppMessage = value.ToString();
            // Add custom validation logic here
            string[] allowedValues = { "Y", "N" };
            if (!allowedValues.Contains(allowWhatsAppMessage))
            {
                return new ValidationResult("Invalid value for AllowWhatsAppMessage. Allowed values are Y or N.");
            }
        }
        // Return success if value is null or matches the allowed values
        return ValidationResult.Success;
    }
}


