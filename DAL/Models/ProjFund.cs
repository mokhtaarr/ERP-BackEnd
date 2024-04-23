using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjFund
    {
        public int ProjectFundId { get; set; }
        public int? ProjectId { get; set; }
        public int? AccountId { get; set; }
        public string? FundName1 { get; set; }
        public string? FundName2 { get; set; }
        public decimal? FundPercent { get; set; }
        public decimal? FundValue { get; set; }
        public string? Description { get; set; }
        public string? Contact { get; set; }

        public virtual ProjProject? Project { get; set; }
    }
}
