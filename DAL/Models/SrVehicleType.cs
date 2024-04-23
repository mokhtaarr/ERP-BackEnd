using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrVehicleType
    {
        public SrVehicleType()
        {
            SrVehicles = new HashSet<SrVehicle>();
        }

        public int VehicleTypId { get; set; }
        public string? TypeCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Remark { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SrVehicle> SrVehicles { get; set; }
    }
}
