using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalBudget
    {
        public CalBudget()
        {
            CalBudgetDetails = new HashSet<CalBudgetDetail>();
        }

        public int BudgetId { get; set; }
        public int? StorId { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public int? Aid { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? FromFinancialIntervalsId { get; set; }
        public int? ToFinancialIntervalsId { get; set; }
        public string? ScinarioDesc { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? Remarks { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }

        public virtual ICollection<CalBudgetDetail> CalBudgetDetails { get; set; }
    }
}
