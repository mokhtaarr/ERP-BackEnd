using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrJobSwage
    {
        public int JobStechId { get; set; }
        public int? JorderId { get; set; }
        public int? EmpId { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName1 { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? HourlyCostRate { get; set; }
        public decimal? Wvalue { get; set; }
        public string? Wdescription { get; set; }

        public virtual SrJobOrder? Jorder { get; set; }
    }
}
