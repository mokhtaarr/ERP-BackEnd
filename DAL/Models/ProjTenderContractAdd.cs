using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderContractAdd
    {
        public int TenderContractAddId { get; set; }
        public int? TenderContractId { get; set; }
        public int? AccountId { get; set; }
        public string? HelpAccType { get; set; }
        public decimal? PercentNum { get; set; }
        public decimal? AddValu { get; set; }
        public bool? AddToExtract { get; set; }
        public decimal? AddPercent { get; set; }
        public bool? AffectContract { get; set; }
        public bool? CanExceedValu { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }

        public virtual ProjTenderContract? TenderContract { get; set; }
    }
}
