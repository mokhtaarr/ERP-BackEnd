using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdEmpJobOrderDistribDetail
    {
        public int EmpJobOrderDistDetailId { get; set; }
        public int? EmpJobOrderDistId { get; set; }
        public int? EquipId { get; set; }
        public int? EmpId { get; set; }
        public int? JobOrderId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }

        public virtual ProdEmpJobOrderDistrib? EmpJobOrderDist { get; set; }
    }
}
