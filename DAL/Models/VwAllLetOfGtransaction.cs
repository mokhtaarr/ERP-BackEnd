using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAllLetOfGtransaction
    {
        public int LetOfGrnteeTranId { get; set; }
        public int? LetOfGrnteeId { get; set; }
        public int? TrNo { get; set; }
        public string? DocTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public decimal? Rate { get; set; }
        public string? StatusName1 { get; set; }
        public string? CategoryName1 { get; set; }
        public string? TypeName1 { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CurrencyDescA { get; set; }
        public bool? DefualtCurrency { get; set; }
        public string? CurrencySymbol { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
        public string? LetterOfGuaranteeName1 { get; set; }
        public string? LetterOfGuaranteeName2 { get; set; }
        public string LetterOfGuaranteeCode { get; set; } = null!;
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public decimal? ValueBeforeRate { get; set; }
        public decimal? Commision { get; set; }
        public decimal? CoverValue { get; set; }
        public decimal? Expenses { get; set; }
        public DateTime? LetEndDate { get; set; }
    }
}
