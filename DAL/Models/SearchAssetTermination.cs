using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchAssetTermination
    {
        public string? DocTrNo { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public string? Remarks1 { get; set; }
        public string? AssetCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public bool? IsProduction { get; set; }
        public int? RemainInstallments { get; set; }
        public int? InstallMentCount { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Remarks { get; set; }
        public string? CatCode { get; set; }
        public string? CatDescA { get; set; }
        public DateTime? LastDeprDate { get; set; }
        public decimal? DeprValue { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
    }
}
