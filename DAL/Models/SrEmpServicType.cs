using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrEmpServicType
    {
        public int SrId { get; set; }
        public int? EmpId { get; set; }
        public int? SrTypId { get; set; }

        public virtual HrEmployee? Emp { get; set; }
        public virtual SrServiceType? SrTyp { get; set; }
    }
}
