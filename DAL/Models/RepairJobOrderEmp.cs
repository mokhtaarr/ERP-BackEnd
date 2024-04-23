using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RepairJobOrderEmp
    {
        public int RepairEmpId { get; set; }
        public int? RepairId { get; set; }
        public int? EmpId { get; set; }
        public int? BillOfMaterialId { get; set; }
        public decimal? ServiceValue { get; set; }
        public decimal? TimeBeforFormat { get; set; }
        /// <summary>
        /// 1 Minutes, 2 Hours,3 Days, 4 Months
        /// </summary>
        public byte? TimeUnit { get; set; }
        public decimal? Minutes { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Days { get; set; }
        public decimal? Months { get; set; }
        public decimal? OtherCost { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual RepairJobOrder? Repair { get; set; }
    }
}
