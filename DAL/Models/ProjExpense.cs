using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjExpense
    {
        public int ProjectExpensId { get; set; }
        public int? ProjectId { get; set; }
        public int? ExpensesId { get; set; }
        public decimal? EstimateValue { get; set; }
        public decimal? EstimatePercent { get; set; }
        public decimal? RealValue { get; set; }
        public decimal? RealPercent { get; set; }

        public virtual ProjProject? Project { get; set; }
    }
}
