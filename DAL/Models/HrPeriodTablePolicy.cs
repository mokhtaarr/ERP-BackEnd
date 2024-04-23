using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrPeriodTablePolicy
    {
        public int PeriodPolicyId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? AttendElementId { get; set; }
        public byte? AttendUnit { get; set; }
        public decimal? Approximate { get; set; }
        public decimal? Minimum { get; set; }

        public virtual HrPeriodsTable? PeriodTable { get; set; }
    }
}
