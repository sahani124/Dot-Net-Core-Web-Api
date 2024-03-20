using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SampleApi.Controllers.Model
{
    public class RequestExmCenter
    {


        [Required]
        public string URN { get; set; }

        [Required]
        [ValidDateFormat("dd-MM-yyyy")]
        public string PreferredDate { get; set; }
        [Required]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address")]
        public string EmailId { get; set; }
        [Required]
        [RegularExpression("^(BULK|SINGLE)$", ErrorMessage = "Batch Mode must be 'BULK' or 'SINGLE'")]
        public string BatchMode { get; set; }
       [Required]
        [RegularExpression("^(ONLINE PAYMENT|CREDIT)$", ErrorMessage = "Payment Mode must be 'ONLINE PAYMENT' or 'CREDIT'")]

        public string PaymentMode { get; set; }
        [Required]
        [RegularExpression("^(AUTO|SELF)$", ErrorMessage = "Scheduling Mode must be 'AUTO' or 'SELF'")]

        public string SchedulingMode { get; set; }

        [Required]
        //[RegularExpression("(Male|Female)")]
        public string PrimaryProfession { get; set; }


    }
}

public class ValidDateFormatAttribute : ValidationAttribute
{
    private readonly string _dateFormat;

    public ValidDateFormatAttribute(string dateFormat)
    {
        _dateFormat = dateFormat;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
        {
            // If the value is null and [Required] attribute is applied, it will handle the validation.
            return ValidationResult.Success;
        }

        DateTime parsedDate;
        var isValid = DateTime.TryParseExact(
            Convert.ToString(value),
            _dateFormat,
            System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None,
            out parsedDate);

        if (!isValid)
        {
            return new ValidationResult($"The date is not in the correct format: {_dateFormat}");
        }

        return ValidationResult.Success;
    }
}


//pincode
//