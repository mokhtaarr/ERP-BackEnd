using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrEmpSalaryDistribution
    {
        public int SalaryDistId { get; set; }
        public int? EmpId { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        public decimal? SalaryPercent { get; set; }
    }
}
