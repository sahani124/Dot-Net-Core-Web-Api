using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SampleApi.Controllers.Model;
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
        RequestCandidate CndData = new RequestCandidate();
        [Route("api/KmiExam/GenURN")]
        [HttpPost]
     
        public ActionResult<IEnumerable<ApiResult>> GenURN(RequestCandidate CndData)
        {
            try
            {
                if (CndData == null)
                {
                    return BadRequest("Invalid request data");
                }
                else
                {
                    var results = ExamContext.ApiResult.FromSqlRaw("EXEC Prc_ApiResult @PAN", new SqlParameter("@PAN", CndData.PAN)).ToList();
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
    }
}
