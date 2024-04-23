using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrJob
    {
        public HrJob()
        {
            HrEmployees = new HashSet<HrEmployee>();
        }

        public int JobId { get; set; }
        public int? DepartMentId { get; set; }
        public string? Jcode { get; set; }
        public string? Jname1 { get; set; }
        public string? Jname2 { get; set; }
        public string? Jdesc { get; set; }
        public string? Jresponsibilities { get; set; }
        public string? Jduties { get; set; }
        public string? Jqualifications { get; set; }
        public string? Remarks { get; set; }
        public string? Add1 { get; set; }
        public int? ParentId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? StandardMonthlyWage { get; set; }
        public byte? StandardHolyDays { get; set; }
        public decimal? StandardDailyWage { get; set; }
        public decimal? StandardDailyWorkHours { get; set; }
        public decimal? StandardHourlyWage { get; set; }
        public int? NumberAvailable { get; set; }
        public bool? TestMandatory { get; set; }

        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
    }
}
