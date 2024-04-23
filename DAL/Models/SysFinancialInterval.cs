using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysFinancialInterval
    {
        public int FinancialIntervalsId { get; set; }
        public string? FinancialIntervalCode { get; set; }
        public string? MonthNameA { get; set; }
        public string? MonthNameE { get; set; }
        public DateTime? StartingFrom { get; set; }
        public string? StartingFromHijri { get; set; }
        public DateTime? EndingDate { get; set; }
        public string? EndToHijri { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsInUse { get; set; }
        public string? StopReason { get; set; }
        public int? StoppedByUserId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? FinancialYearId { get; set; }

        public virtual SysFinancialYear? FinancialYear { get; set; }
    }
}
