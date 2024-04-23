using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrVehicleMovementDetail
    {
        public int VehiclMovDetailId { get; set; }
        public int? VehiclMovId { get; set; }
        /// <summary>
        /// ItemCardId
        /// </summary>
        public int? VehicleId { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public decimal? NetTime { get; set; }
        public decimal? DayCost { get; set; }
        public decimal? TotalPrice { get; set; }
        public string? DriverName { get; set; }
        public string? Remarks { get; set; }

        public virtual SrVehicleMovement? VehiclMov { get; set; }
    }
}
