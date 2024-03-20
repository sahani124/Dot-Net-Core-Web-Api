//using SampleApi.Modal.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static CustomGenderValidationAttribute;

namespace SampleApi.Modal
{
    public class RequestURNUpdate
    {

        public string newURN { get; set; }
        public string URN { get; set; }
        [SalutationCheck]
        public string Salutation { get; set; }
       
        public string CandidateName { get; set; }
        [Required]
        public string FathersName { get; set; }
        [Required]
        public string InsuranceCategory { get; set; }
        
        public string CoR { get; set; }
        [Required]
        public string DOB { get; set; }
       [CustomGenderValidation]
        public string Gender { get; set; }
        [CategoryValidation]
        public string Category { get; set; }
        [AreaValidation]
        public string Area { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string PAN { get; set; }
        public string DrivingLicense { get; set; }
        public string PassportNo { get; set; }
        public string VoterId { get; set; }
        public string PhotoId { get; set; }
        [Required]
        public string BasicQualification { get; set; }
        [Required]
        public string BasicQualificationBoardName { get; set; }
        [Required]
        public string BasicQualificationRollNumber { get; set; }
        [Required]
        public string BasicQualificationYearofPassing { get; set; }
        [Required]
        public string ProfessionalQualification { get; set; }
        public string OtherQualification { get; set; }
        [Required]
        public string CurrentHouseNo { get; set; }
        [Required]
        public string PrimaryProfession { get; set; }
        [Required]
        public string InsurerRefNo { get; set; }

        [Required]
        public string ExaminationCenter { get; set; }

        [Required]
        public string ExamLanguage { get; set; }

        [Required]
        public string Photo { get; set; }

        [Required]
        public string Signature { get; set; }

        [AllowWhatsAppMessageValidation]
        public string AllowWhatsAppMessage { get; set; }

        [Required]
        public string WhatsAppNumber { get; set; }

        [Required]
        public string CurrentStreet { get; set; }

        [Required]
        public string ContactPersonsEmailIdr { get; set; }

        [Required]
        public string CurrentTown { get; set; }

        [Required]
        public string CurrentState { get; set; }

        [Required]
        public string CurrentDistrict { get; set; }

        [Required]
        public int CurrentPincode { get; set; }

        [Required]
        public string PermanentHouseNo { get; set; }

        [Required]
        public string PermanentTown { get; set; }

        [Required]
        public string PermanentState { get; set; }
        public string PermanentDistrict { get; set; }
        [Required]
        public int PermanentPincode { get; set; }
        public string LandLine { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string EmailId { get; set; }
        //RuleFor(x => x.Salutation).NotEmpty().WithMessage("Salutation is required.");


    }
}
