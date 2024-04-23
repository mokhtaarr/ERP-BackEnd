using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchDepreciationDoc
    {
        public string? DocTrNo { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public decimal? TotalDeprVal { get; set; }
        public int? FinancialYearsCode { get; set; }
        public string? FinancialYearNameA { get; set; }
        public string? FinancialYearNameE { get; set; }
        public string? FinancialIntervalCode { get; set; }
        public string? MonthNameA { get; set; }
        public string? MonthNameE { get; set; }
        public DateTime? StartingFrom { get; set; }
        public DateTime? EndingDate { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
    }
}
