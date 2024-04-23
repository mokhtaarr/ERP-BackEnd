using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrWarranty
    {
        public SrWarranty()
        {
            SrVehicles = new HashSet<SrVehicle>();
        }

        public int Wid { get; set; }
        public string? Wcode { get; set; }
        public string? Wname1 { get; set; }
        public string? Wname2 { get; set; }
        public string? Wconditions { get; set; }
        /// <summary>
        /// 0 periodic,1 distance, 2 both
        /// </summary>
        public byte? Wmethod { get; set; }
        public int? WperiodMonths { get; set; }
        public int? Wdistance { get; set; }
        public bool? Wuse { get; set; }
        public bool? Exemption { get; set; }
        public byte? ExemptionPercnt { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SrVehicle> SrVehicles { get; set; }
    }
}
