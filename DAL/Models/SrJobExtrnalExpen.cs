using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrJobExtrnalExpen
    {
        public int JobExpensId { get; set; }
        public int? JorderId { get; set; }
        public int? ResponsibleEmpId { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName1 { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? Expvalue { get; set; }
        public string? Expdescription { get; set; }

        public virtual SrJobOrder? Jorder { get; set; }
    }
}
