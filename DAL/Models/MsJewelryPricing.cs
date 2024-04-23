using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsJewelryPricing
    {
        public int GoldPricingId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? GlobalOuncePrice { get; set; }
        public decimal? GlobalKiloPrice { get; set; }
        public decimal? GlobalGramPrice { get; set; }
        public decimal? Rate { get; set; }
        public decimal? LocalOuncePrice { get; set; }
        public decimal? LocalKiloPrice { get; set; }
        public decimal? LocaGramPrice { get; set; }
        /// <summary>
        /// 18,21,24
        /// </summary>
        public decimal? Kirat { get; set; }
        public decimal? KiratLocalPrice { get; set; }
        public decimal? KiratGlobalPrice { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
