using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SalesInvCustSearch
    {
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public decimal? NetPrice { get; set; }
        public int? StoreId { get; set; }
        public string? InvDescA { get; set; }
        public string? InvDescE { get; set; }
        public string? Remarks { get; set; }
        public string? CustBranchName1 { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int InvId { get; set; }
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
        public string? SalesOfferDocTrNo { get; set; }
        public bool IsPos { get; set; }
        public string? DeletedBy { get; set; }
        public bool? IsHold { get; set; }
        public string? Desc1 { get; set; }
        public string? Desc2 { get; set; }
        public decimal? PayMethodPercent { get; set; }
        public decimal? PayMethodValue { get; set; }
        public string? PayMethodDatafield { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
    }
}
