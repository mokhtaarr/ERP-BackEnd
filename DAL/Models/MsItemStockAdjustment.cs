using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemStockAdjustment
    {
        public MsItemStockAdjustment()
        {
            MsItemStockAdjustmentDetails = new HashSet<MsItemStockAdjustmentDetail>();
        }

        public int StockAdjustId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? StorId { get; set; }
        public int? StorePartId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public decimal? StockTotalCost { get; set; }
        public string? Remarks { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public bool? IsStockOpenning { get; set; }
        public bool? IsReevaluation { get; set; }
        public bool? IsPrinted { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }

        public virtual ICollection<MsItemStockAdjustmentDetail> MsItemStockAdjustmentDetails { get; set; }
    }
}
