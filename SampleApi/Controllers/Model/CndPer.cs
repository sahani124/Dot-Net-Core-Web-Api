using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers.Model
{
    [Table("CndPer")]
    public class CndPer
    {
        [Column("CarriedCode")]
        public string? CarriedCode { get; set; }

        [Column("ApplicationNo")]
        public string? ApplicationNo { get; set; }

        [Column("CndNo")]
        public string? CndNo { get; set; }

        [Column("PAN")]
        public string? PAN { get; set; }

        [Column("AadharNo")]
        public string? AadharNo { get; set; }

        [Column("AadharOTP")]
        public string? AadharOTP { get; set; }

        [Column("TypeofAadharVerify")]
        public string? TypeofAadharVerify { get; set; }

        [Column("ProofIDDoc")]
        public string? ProofIDDoc { get; set; }

        [Column("HasPhoto")]
        public char? HasPhoto { get; set; }

        [Column("HasMarkSheet")]
        public char? HasMarkSheet { get; set; }

        [Column("HasCertificate")]
        public char? HasCertificate { get; set; }

        [Column("CreateBy")]
        public string? CreateBy { get; set; }

        [Column("CreateDtim")]
        public DateTime? CreateDtim { get; set; }

        [Column("UpdateBy")]
        public string? UpdateBy { get; set; }

        [Column("UpdateDtim")]
        public DateTime? UpdateDtim { get; set; }

        [Key]
        [Column("RecId")]
        public int? RecId { get; set; }
        
    }
   
}
