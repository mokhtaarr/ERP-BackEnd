using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAllDailyTransactionsForReview
    {
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? Remarks { get; set; }
        public string? PrefixCode { get; set; }
        public string? BookNameAr { get; set; }
        public string? DocTrNo { get; set; }
        public bool? IsOpenningTerm { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public string Idname { get; set; } = null!;
        public string SourcTyp { get; set; } = null!;
        public string? SourceCode { get; set; }
        public string? SourceName { get; set; }
        public string? AnalizCode { get; set; }
        public string? AnalizName1 { get; set; }
        public string? AnalizName2 { get; set; }
        public decimal? Rate { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CurrencyDescA { get; set; }
        public string? CurrencyDescE { get; set; }
        public string DocType { get; set; } = null!;
        public string DocTypeAr { get; set; } = null!;
        public int? StoreId { get; set; }
    }
}
