using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers.Model
{
    public class RequestCandidate
    {
        public string Salutation { get; set; }
        public string CandidateName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Category { get; set; }
        public string Area { get; set; }
        public string Nationality { get; set; }
        public string PAN { get; set; }
        public string DrivingLicense { get; set; }
        public string PassportNo { get; set; }
    }
}


