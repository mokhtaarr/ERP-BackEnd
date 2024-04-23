using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockOpenningBalance
    {
        public StockOpenningBalance()
        {
            StockOpenningBalanceDetails = new HashSet<StockOpenningBalanceDetail>();
        }

        public int StockOpenId { get; set; }
        public int? StockTranTypId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? StockPortfolioId { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public bool? FollowCash { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<StockOpenningBalanceDetail> StockOpenningBalanceDetails { get; set; }
    }
}
