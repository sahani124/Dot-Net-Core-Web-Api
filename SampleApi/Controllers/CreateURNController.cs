using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SampleApi.Controllers.Model;
using SampleApi.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]    
    [ApiController]
    public class CreateURNController : ControllerBase
    {
        public ExamContext ExamContext { get; set; }
        public CreateURNController(ExamContext examContext)
        {
            ExamContext = examContext;
        }
        
        [Route("KmiExam/GenURN")]
       
        [HttpPost]
     
        public ActionResult<IEnumerable<ApiResult>> GenURN(RequestURNGenerate CndData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    // Model is not valid, return validation errors
                    return BadRequest(ModelState);
                }
                else
                {
                   
                    // var results2 = UsrmgmtContext.SponsorshipRecord.FromSqlRaw("EXEC Prc_GetSponsorshipRcrd @ColumnName", new SqlParameter("@ColumnName", "")).ToList();
                 
                    var results = ExamContext.ApiResult.FromSqlRaw("EXEC Prc_URNGenrate @PAN", new SqlParameter("@PAN", CndData.PAN)).ToList();
                    return Ok(results);
                }
            }
            catch (Exception e)
            {
                var errorResponse = new
                {
                    HasError = true,
                    Message = "Internal Server Error: An error occurred while processing your request",
                    Data = ""
                };
                return StatusCode(500, errorResponse);
            }
        }


        [Route("KmiExam/UpdateURN")]
        [HttpPost]

        public ActionResult<IEnumerable<ApiResult>> UpdateURN(RequestURNUpdate CndData)
        {
            try
            {
                if (CndData == null)
                {
                    return BadRequest("Invalid request data");
                }
                else
                {
                    var results = ExamContext.ApiResult.FromSqlRaw("EXEC Prc_UpdateURN @PAN", new SqlParameter("@PAN", CndData.PAN)).ToList();
                    return Ok(results);
                }
            }
            catch (Exception e)
            {
                var errorResponse = new
                {
                    HasError = true,
                    Message = "Internal Server Error: An error occurred while processing your request",
                    Data = ""
                };
                return StatusCode(500, errorResponse);
            }
        }
        

        [Route("KmiExam/ExamRegistration")]
        [HttpPost]

        public ActionResult<IEnumerable<ApiResult>> ExamRegistration(RequestExmCenter CndData)
        {
            try
            {
                if (CndData == null)
                {
                    return BadRequest("Invalid request data");
                }
                else
                {
                    var results = new
                    {
                        HasError = "False",
                        Message = "",
                        Data = new
                        {
                            list = new[]
         {
            new
            {
                URN = "ABCI0101230001",
                PreferredDate = "31-Mar-2023",
                EmailId = "abcd@abcd.com",
                BatchMode = "Single",
                PaymentMode = "Online Payment",
                SchedulingMode = "AUTO",
                IsValid = true,
                Error = "",
                ExamBatchNo = "ABCD12312312323"
            }
            ,
            new
            {
                URN = "ABCI0101230001",
                PreferredDate = "31-Mar-2023",
                EmailId = "abcd@abcd.com",
                BatchMode = "Single",
                PaymentMode = "Online Payment",
                SchedulingMode = "AUTO",
                IsValid = true,
                Error = "",
                ExamBatchNo = "ABCD12312312323"
            }
        }
                        }
                    };


                    return Ok(results);
                }
            }
            catch (Exception e)
            {
                var errorResponse = new
                {
                    HasError = true,
                    Message = "Internal Server Error: An error occurred while processing your request",
                    Data = ""
                };
                return StatusCode(500, errorResponse);
            }
        }

         [Route("api/KmiExam/DuplicateURN")]
        [HttpPost]

        public IActionResult DuplicateURN(RequestURNGenerate CndData)
        {
            try
            {
                if (CndData == null)
                {
                    return BadRequest("Invalid request data");
                }
                else
                {
                    var results = new
                    {
                        HasError = "false",
                        Message = "",
                        Data = new
                        {
                            URN = "ABCI0101230001",
                            NewURN = "ABCI010122424",
                            Remarks = "Remarks as required"
                        }
                    };
                    return Ok(results);
                }
            }
            catch (Exception e)
            {
                var errorResponse = new
                {
                    HasError = true,
                    Message = "Internal Server Error: An error occurred while processing your request",
                    Data = ""
                };
                return StatusCode(500, errorResponse);
            }
        }
        //[Route("api/KmiExam/GetExamCenter")]
        //[HttpPost]
        //public IActionResult GetExamCenter(RequestCandidate CndData)
        //{
        //    try
        //    {
        //        if (CndData == null)
        //        {
        //            return BadRequest("Invalid request data");
        //        }
        //        else
        //        {
        //            var results = ExamContext.ExmCentreList.FromSqlRaw("EXEC Prc_GetExmCenteName").ToList();
        //            // var results = ExamContext.ApiResult.FromSqlRaw("EXEC Prc_GetExmCenteName @PAN", new SqlParameter("@PAN", CndData.PAN)).ToList();
        //            return Ok(results);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        var errorResponse = new
        //        {
        //            HasError = true,
        //            Message = "Internal Server Error: An error occurred while processing your request",
        //            Data = ""
        //        };
        //        return StatusCode(500, errorResponse);
        //    }
        //}
    }
}
