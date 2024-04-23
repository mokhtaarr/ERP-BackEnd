using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrPeriodTableDetail
    {
        public int PeriodTablDetailId { get; set; }
        public int? PeriodTableId { get; set; }
        public string? SubPeriodCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public DateTime? PeriodStrtDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public DateTime? PayDayDate { get; set; }
        public decimal? TotalWorkDays { get; set; }
        public decimal? TotalWorkHours { get; set; }
        public decimal? TotalVacsDays { get; set; }
        public decimal? TotalVacsHours { get; set; }
        public byte? TotalDays { get; set; }

        public virtual HrPeriodsTable? PeriodTable { get; set; }
    }
}
