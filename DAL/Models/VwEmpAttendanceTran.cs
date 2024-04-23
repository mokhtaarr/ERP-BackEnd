using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwEmpAttendanceTran
    {
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? DocTrNo { get; set; }
        public int? DepartMentId { get; set; }
        public int AttendDocDetailsId { get; set; }
        public int AttendDocId { get; set; }
        public string? EmpCode { get; set; }
        public string? DeviceEmpCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? DepartCode { get; set; }
        public string? DepartName1 { get; set; }
        public string? DepartName2 { get; set; }
        public string? Jcode { get; set; }
        public string? Jname1 { get; set; }
        public string? Jname2 { get; set; }
        public string? PeriodCode { get; set; }
        public string? PeriodName1 { get; set; }
        public string? PeriodName2 { get; set; }
        public string? SubPeriodCode { get; set; }
        public string? SubPeriodName1 { get; set; }
        public string? SubPeriodName2 { get; set; }
        public DateTime? PeriodStrtDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public DateTime? PayDayDate { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreDescA { get; set; }
        public string? StoreDescE { get; set; }
        public decimal? TotalWorkHours { get; set; }
        public decimal? TotalVacsHours { get; set; }
        public int? EmpId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int? PeriodTableId { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
