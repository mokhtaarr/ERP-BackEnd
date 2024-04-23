using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrActivityDetailElement
    {
        public int ActivityElementId { get; set; }
        public int? EmpActivityDetailId { get; set; }
        public int? EmpActivityId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int? EmpId { get; set; }
        public int? AttendElementId { get; set; }
        public int? EmpElementId { get; set; }
        public byte? TimeUnit { get; set; }
        public decimal? Value { get; set; }
        public string? TextValu { get; set; }

        public virtual HrEmpActivityDetail? EmpActivityDetail { get; set; }
    }
}
