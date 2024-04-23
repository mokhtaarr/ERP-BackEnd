using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockRecCustSearch
    {
        public int TrNo { get; set; }
        public int? StoreId { get; set; }
        public DateTime? TrDate { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int StockRecId { get; set; }
        public int? BookId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public bool? CostExecuted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? ReceiptrQty { get; set; }
        public string? StrCustm4 { get; set; }
        public string? StrCustm5 { get; set; }
    }
}
