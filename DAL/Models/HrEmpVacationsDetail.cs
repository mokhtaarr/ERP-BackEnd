using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrEmpVacationsDetail
    {
        public int EmpVacDetailId { get; set; }
        public int? EmpVacId { get; set; }
        public int? EmpId { get; set; }
        public byte? OldAnnualVacs { get; set; }
        public byte? OldReservedVacs { get; set; }
        public byte? OldAnnualBalance { get; set; }
        public byte? OldReservedVacsBalance { get; set; }
        public byte? AnnualVacs { get; set; }
        public byte? ReservedVacs { get; set; }
        public byte? AnnualBalance { get; set; }
        public byte? ReservedVacsBalance { get; set; }
        public DateTime? StartDate { get; set; }
        public string? Remarks { get; set; }

        public virtual HrEmpVacation? EmpVac { get; set; }
    }
}
