using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderContractDiscount
    {
        public int TenderContractDiscId { get; set; }
        public int? TenderContractId { get; set; }
        public int? AccountId { get; set; }
        public string? HelpAccType { get; set; }
        public bool? Accomulative { get; set; }
        public decimal? CurrentPercent { get; set; }
        public decimal? DiscValu { get; set; }
        public bool? DiscFromExtract { get; set; }
        public decimal? DiscPercent { get; set; }
        public bool? AffectContract { get; set; }
        public bool? CanExceedValu { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }

        public virtual ProjTenderContract? TenderContract { get; set; }
    }
}
