using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetAdjustMentsByVend
    {
        public string? DocTrNo { get; set; }
        public string? PrefixCode { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? CurrencyDescA { get; set; }
        public string VendorCode { get; set; } = null!;
        public string? VendorDescA { get; set; }
        public decimal? Value { get; set; }
        public string? Remarks { get; set; }
        public byte? CurrencyId { get; set; }
        public int AdjustId { get; set; }
        public int? BookId { get; set; }
        public int? StoreId { get; set; }
    }
}
