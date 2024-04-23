using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrVehicleJobOrderDetail
    {
        public int VjorderDetailId { get; set; }
        public int? VjorderId { get; set; }
        public int? TrafficLineId { get; set; }
        public int? DriverId { get; set; }
        public int? CustomerId { get; set; }
        public int? HotelId { get; set; }
        public int? TripId { get; set; }
        public int? ContainerTypeId { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public decimal? Km { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public int? ContainersCount { get; set; }
        public decimal? ContainerWeight { get; set; }
        public decimal? WaitTime { get; set; }
        public bool? IsDamade { get; set; }
        public string? DamadeDesc { get; set; }
        public string? Remarks { get; set; }
        public string? Representative { get; set; }
        public int? PersonsCount { get; set; }
        public string? PlaceToStart { get; set; }
        public string? PlaceToEnd { get; set; }
        public string? CompanyName { get; set; }

        public virtual SrDriver? Driver { get; set; }
        public virtual SrVehicleJobOrder? Vjorder { get; set; }
    }
}
