﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchAttendanceDoc
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
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
    }
}
