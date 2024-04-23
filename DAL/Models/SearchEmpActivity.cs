using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchEmpActivity
    {
        public string? DocTrNo { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public string? Remarks1 { get; set; }
        public string? SubPeriodCode { get; set; }
        public string? PeriodName1 { get; set; }
        public string? PeriodName2 { get; set; }
        public decimal? TotalWorkDays { get; set; }
        public decimal? TotalWorkHours { get; set; }
        public decimal? TotalVacsDays { get; set; }
        public decimal? TotalVacsHours { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
    }
}
