using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchProductionOrder
    {
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? Quantity { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int ProductionOrderId { get; set; }
        public string? UnitCode { get; set; }
        public string? UnitNam { get; set; }
        public string? UnitNameE { get; set; }
        public decimal? UnittRate { get; set; }
        public int? BookId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
    }
}
