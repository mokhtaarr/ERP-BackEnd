using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class HrJobDto
    {
        public int? JobId { get; set; }
        public int? DepartMentId { get; set; }
        public string? Jcode { get; set; }
        public string? Jname1 { get; set; }
        public string? Jname2 { get; set; }
        public string? Jdesc { get; set; }
        public string? Jresponsibilities { get; set; }
        public string? Jduties { get; set; }
        public string? Jqualifications { get; set; }
        public string? Remarks { get; set; }
        public int? ParentId { get; set; }
        public decimal? StandardMonthlyWage { get; set; }
        public byte? StandardHolyDays { get; set; }
        public decimal? StandardDailyWage { get; set; }
        public decimal? StandardDailyWorkHours { get; set; }
        public decimal? StandardHourlyWage { get; set; }
        public int? NumberAvailable { get; set; }

    }
}
