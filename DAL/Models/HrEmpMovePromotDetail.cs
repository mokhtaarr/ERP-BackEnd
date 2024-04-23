using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrEmpMovePromotDetail
    {
        public int EmpMoveDetailId { get; set; }
        public int? EmpMoveId { get; set; }
        public int? EmpId { get; set; }
        public int? SalaryTypId { get; set; }
        public decimal? OldSalaryValu { get; set; }
        public decimal? SalaryValu { get; set; }

        public virtual HrEmpMovePromotion? EmpMove { get; set; }
    }
}
