using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrEmpSalaryType
    {
        public int EmpSalaryTypesId { get; set; }
        public int? EmpId { get; set; }
        public int? SalaryTypId { get; set; }
        public decimal? SalaryValu { get; set; }
        public int? DebitAccId { get; set; }
        public int? CreditAccId { get; set; }
        public int? DebitCostCenterId { get; set; }
        public int? CreditCostCenterId { get; set; }
        public int? DebitEmpAccountId { get; set; }
        public int? CreditEmpAccountId { get; set; }

        public virtual HrEmployee? Emp { get; set; }
        public virtual HrSalaryType? SalaryTyp { get; set; }
    }
}
