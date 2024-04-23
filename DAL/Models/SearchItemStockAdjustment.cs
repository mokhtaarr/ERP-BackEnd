using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchItemStockAdjustment
    {
        public int? StorId { get; set; }
        public int? StorePartId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? StockTotalCost { get; set; }
        public string? ManualTrNo { get; set; }
        public string PartCode { get; set; } = null!;
        public string? PartDescA { get; set; }
        public string? PartDescE { get; set; }
        public string StoreCode { get; set; } = null!;
        public string? StoreDescA { get; set; }
        public string? StoreDescE { get; set; }
        public int StockAdjustId { get; set; }
        public string? DocTrNo { get; set; }
        public bool? IsStockOpenning { get; set; }
        public bool? IsReevaluation { get; set; }
        public string? Remarks { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
    }
}
