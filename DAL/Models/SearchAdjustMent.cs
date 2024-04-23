using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchAdjustMent
    {
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string AdjustType { get; set; } = null!;
        public string AdjustSourceType { get; set; } = null!;
        public string? AdjustSourceName { get; set; }
        public decimal? Value { get; set; }
        public string? StoreDescA { get; set; }
        public int? StoreId { get; set; }
        public string? DocTrNo { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
    }
}
