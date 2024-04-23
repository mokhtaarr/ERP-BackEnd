using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrTransportation
    {
        public int TransPortId { get; set; }
        public int? TripId { get; set; }
        public int? VehicleId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Departure { get; set; }
        public DateTime? Arrival { get; set; }
        public int? TrafficLineId { get; set; }
        public int? CityIdfrom { get; set; }
        public int? CityIdto { get; set; }
        public string? PlaceFrom { get; set; }
        public string? PlaceTo { get; set; }
        public string? Remarks { get; set; }

        public virtual SrTrip? Trip { get; set; }
    }
}
