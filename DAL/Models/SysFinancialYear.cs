using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysFinancialYear
    {
        public SysFinancialYear()
        {
            SysFinancialIntervals = new HashSet<SysFinancialInterval>();
        }

        public int FinancialYearsId { get; set; }
        public int? FinancialYearsCode { get; set; }
        public string? FinancialYearNameA { get; set; }
        public string? FinancialYearNameE { get; set; }
        public DateTime? StartingFrom { get; set; }
        public string? StartingFromHijri { get; set; }
        public DateTime? EndTo { get; set; }
        public string? EndToHijri { get; set; }
        public DateTime? ClosingDate { get; set; }
        public string? ClosingDateHijri { get; set; }
        public string? YearState { get; set; }
        public int? NoOfIntervals { get; set; }
        public bool? YearType { get; set; }
        public byte? SubPeriodsType { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsActive { get; set; }
        public string? StopReason { get; set; }
        public int? StoppedByUserId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SysFinancialInterval> SysFinancialIntervals { get; set; }
    }
}
