using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers.Model
{
    public class AddParametersList
    {
        public List<SqlParameter> URNGenPramList(RequestURNGenerate CndData)
        {
            var parameters = new List<SqlParameter>
        {
            new SqlParameter("@Salutation", CndData.Salutation),
            new SqlParameter("@CandidateName", CndData.CandidateName),
            new SqlParameter("@FathersName", CndData.FathersName),
            new SqlParameter("@InsuranceCategory", CndData.InsuranceCategory),
            new SqlParameter("@CoR", CndData.CoR),
            new SqlParameter("@DOB", CndData.DOB),
            new SqlParameter("@Gender", CndData.Gender),
            new SqlParameter("@Category", CndData.Category),
            new SqlParameter("@Area", CndData.Area),
            new SqlParameter("@Nationality", CndData.Nationality),
            new SqlParameter("@PAN", CndData.PAN),
            new SqlParameter("@DrivingLicense", CndData.DrivingLicense),
            new SqlParameter("@PassportNo", CndData.PassportNo),
            new SqlParameter("@VoterId", CndData.VoterId),
            new SqlParameter("@PhotoId", CndData.PhotoId),
            new SqlParameter("@BasicQualification", CndData.BasicQualification),
            new SqlParameter("@BasicQualificationBoardName", CndData.BasicQualificationBoardName),
            new SqlParameter("@BasicQualificationRollNumber", CndData.BasicQualificationRollNumber),
            new SqlParameter("@BasicQualificationYearofPassing", CndData.BasicQualificationYearofPassing),
            new SqlParameter("@ProfessionalQualification", CndData.ProfessionalQualification),
            new SqlParameter("@OtherQualification", CndData.OtherQualification),
            new SqlParameter("@CurrentHouseNo", CndData.CurrentHouseNo),
            new SqlParameter("@PrimaryProfession", CndData.PrimaryProfession),
            new SqlParameter("@InsurerRefNo", CndData.InsurerRefNo),
            new SqlParameter("@ExaminationCenter", CndData.ExaminationCenter),
            new SqlParameter("@ExamLanguage", CndData.ExamLanguage),
            new SqlParameter("@Photo", CndData.Photo),
            new SqlParameter("@Signature", CndData.Signature),
            new SqlParameter("@AllowWhatsAppMessage", CndData.AllowWhatsAppMessage),
            new SqlParameter("@WhatsAppNumber", CndData.WhatsAppNumber),
            new SqlParameter("@CurrentStreet", CndData.CurrentStreet),
            new SqlParameter("@ContactPersonsEmailId", CndData.ContactPersonsEmailId),
            new SqlParameter("@CurrentTown", CndData.CurrentTown),
            new SqlParameter("@CurrentState", CndData.CurrentState),
            new SqlParameter("@CurrentDistrict", CndData.CurrentDistrict),
            new SqlParameter("@CurrentPincode", CndData.CurrentPincode),
            new SqlParameter("@PermanentHouseNo", CndData.PermanentHouseNo),
            new SqlParameter("@PermanentTown", CndData.PermanentTown),
            new SqlParameter("@PermanentState", CndData.PermanentState),
            new SqlParameter("@PermanentDistrict", CndData.PermanentDistrict),
            new SqlParameter("@PermanentPincode", CndData.PermanentPincode),
            new SqlParameter("@LandLine", CndData.LandLine),
            new SqlParameter("@Mobile", CndData.Mobile),
            new SqlParameter("@EmailId", CndData.EmailId)
        };

            return parameters;
        }
    }
}
