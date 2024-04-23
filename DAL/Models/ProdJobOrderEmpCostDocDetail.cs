using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdJobOrderEmpCostDocDetail
    {
        public int JorderEmpDocDetailId { get; set; }
        public int? JorderEmpDocId { get; set; }
        public int? EmpId { get; set; }
        public int? TaskId { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public decimal? ExecutTime { get; set; }
        public decimal? CostHour { get; set; }
        public decimal? TotalCost { get; set; }

        public virtual ProdJobOrderEmpCostDoc? JorderEmpDoc { get; set; }
    }
}
