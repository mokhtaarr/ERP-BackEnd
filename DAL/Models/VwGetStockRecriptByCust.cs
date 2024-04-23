using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetStockRecriptByCust
    {
        public string? DocTrNo { get; set; }
        public string? PrefixCode { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? Remarks { get; set; }
        public decimal? NetPrice { get; set; }
        public string IsCust { get; set; } = null!;
        public int StockRecId { get; set; }
        public int? BookId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
    }
}
