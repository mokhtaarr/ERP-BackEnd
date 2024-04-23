using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalBudgetDetail
    {
        public int BudgetDetailId { get; set; }
        public int? BudgetId { get; set; }
        public int? AccountId { get; set; }
        public int? FromFinancialIntervalsId { get; set; }
        public int? ToFinancialIntervalsId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? CostCenterId { get; set; }
        public string? Remarks { get; set; }

        public virtual CalBudget? Budget { get; set; }
    }
}
