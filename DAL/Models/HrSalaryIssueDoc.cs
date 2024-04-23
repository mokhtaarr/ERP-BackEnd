using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrSalaryIssueDoc
    {
        public HrSalaryIssueDoc()
        {
            HrSalaryIssueDetails = new HashSet<HrSalaryIssueDetail>();
            HrSalaryIssueDistributions = new HashSet<HrSalaryIssueDistribution>();
        }

        public int SalaryIssuDocId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        public int? EmpId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? TotalAddValue { get; set; }
        public decimal? TotalDeduction { get; set; }
        public decimal? TotalOtherValue { get; set; }
        public decimal? NetValue { get; set; }
        public decimal? Rate { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsDelivered { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }

        public virtual ICollection<HrSalaryIssueDetail> HrSalaryIssueDetails { get; set; }
        public virtual ICollection<HrSalaryIssueDistribution> HrSalaryIssueDistributions { get; set; }
    }
}
