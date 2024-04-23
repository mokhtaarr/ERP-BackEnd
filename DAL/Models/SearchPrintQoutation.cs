using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchPrintQoutation
    {
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public bool? IsDraw { get; set; }
        public bool? IsSample { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int PrinQoutId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public decimal? OuterBoxesCount { get; set; }
        public decimal? PartsCount { get; set; }
    }
}
