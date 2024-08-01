using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class SysFinancialYearDto
    {
        public int? FinancialYearsId { get; set; }
        public int? FinancialYearsCode { get; set; }
        public string? FinancialYearNameA { get; set; }
        public string? FinancialYearNameE { get; set; }
        public DateTime? EndTo { get; set; }
        public DateTime? ClosingDate { get; set; }
        public DateTime? StartingFrom { get; set; }
        public int? NoOfIntervals { get; set; }
        public List<SysFinancialIntervalDto>? SysFinancialIntervalList { get;set; }

    }

    public class SysFinancialIntervalDto
    {
        public int? FinancialIntervalsId { get; set; }
        public string? FinancialIntervalCode { get; set; }
        public string? MonthNameA { get; set; }
        public string? MonthNameE { get; set; }
        public DateTime StartingFrom { get; set; }
        public DateTime EndingDate { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsActive { get; set; }

        public int? FinancialYearId { get; set; }
    }
}
