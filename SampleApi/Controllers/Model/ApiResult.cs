using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers.Model
{
    public class ApiResult
    {
        public string HasError { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
    }

}

