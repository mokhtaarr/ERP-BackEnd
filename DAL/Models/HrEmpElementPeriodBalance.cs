using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrEmpElementPeriodBalance
    {
        public int EmpElementId { get; set; }
        public int? EmpId { get; set; }
        public int? AttendElementId { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int? PeriodTableId { get; set; }
        /// <summary>
        /// 1 minute,2 hour,3 day, 4 number
        /// </summary>
        public byte? TimeUnit { get; set; }
        public decimal? ElementValue { get; set; }
    }
}
