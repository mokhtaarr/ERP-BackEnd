using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchVacationEdit
    {
        public string? DocTrNo { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? DayCount { get; set; }
        public int? NetDaysCount { get; set; }
        public string? Remarks1 { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName1 { get; set; }
        public string? EmpName2 { get; set; }
        public string? Jcode { get; set; }
        public string? Jname1 { get; set; }
        public string? Jname2 { get; set; }
        public string? DepartCode { get; set; }
        public string? DepartName1 { get; set; }
        public string? DepartName2 { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreDescA { get; set; }
        public string? StoreDescE { get; set; }
        public int? BookId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
    }
}
