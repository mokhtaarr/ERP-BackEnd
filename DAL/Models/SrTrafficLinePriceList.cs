using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrTrafficLinePriceList
    {
        public int TrafficLineVeiclId { get; set; }
        public int? TrafficLineId { get; set; }
        public int? VehicleId { get; set; }
        public int? ContainerTypeId { get; set; }
        public int? CustomerId { get; set; }
        public int? VendorId { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Price3 { get; set; }
        public decimal? Price4 { get; set; }
        public decimal? Price5 { get; set; }
        public decimal? Price6 { get; set; }
        public decimal? Price7 { get; set; }
        public decimal? Price8 { get; set; }
        public decimal? Price9 { get; set; }
        public decimal? Price10 { get; set; }
        public decimal? Cost { get; set; }
        public string? Remarks { get; set; }

        public virtual SrContainerType? ContainerType { get; set; }
        public virtual SrTrafficLine? TrafficLine { get; set; }
        public virtual SrVehicle? Vehicle { get; set; }
    }
}
