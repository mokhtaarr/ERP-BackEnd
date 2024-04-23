using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrFlight
    {
        public int FlightId { get; set; }
        public int? TripId { get; set; }
        public string? FlightCompany { get; set; }
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
