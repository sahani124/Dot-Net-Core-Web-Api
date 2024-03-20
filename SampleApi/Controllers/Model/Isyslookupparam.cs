using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers.Model
{
    
    [Table("Isyslookupparam")]
    public class Isyslookupparam
    {
      
        [Key]
        public int ID { get; set; }

        public string  LookupCode { get; set; }
        public string ParamValue { get; set; }
        public string ParamDesc01 { get; set; }

    }
}
