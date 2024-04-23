using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PurInvVendSearch
    {
        public int? StorId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? NetPrice { get; set; }
        public string? VendorCode { get; set; }
        public string? VendorDescA { get; set; }
        public string? InvDescA { get; set; }
        public string? InvDescE { get; set; }
        public string? Remarks { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int PurInvId { get; set; }
        public decimal? Rate { get; set; }
        public int? CurrencyId { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CurrencyDescA { get; set; }
        public string? CurrencyDescE { get; set; }
        public bool? DefualtCurrency { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public string? PurOrderDocTrNo { get; set; }
    }
}
