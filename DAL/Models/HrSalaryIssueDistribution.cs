using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrSalaryIssueDistribution
    {
        public int SalaryIssuDistId { get; set; }
        public int? SalaryIssuDocId { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        public decimal? SalaryHours { get; set; }
        public decimal? SalaryDays { get; set; }
        public decimal? SalaryPercent { get; set; }
        public decimal? ValueShare { get; set; }

        public virtual HrSalaryIssueDoc? SalaryIssuDoc { get; set; }
    }
}
