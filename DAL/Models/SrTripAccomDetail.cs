using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrTripAccomDetail
    {
        public int TripAccomDetailId { get; set; }
        public int? AccomodationId { get; set; }
        public int? CustomerId { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? PassPortNo { get; set; }
        public string? RoomNo { get; set; }
        public int? PersonCount { get; set; }
        public string? Remarks { get; set; }

        public virtual SrAccomodation? Accomodation { get; set; }
    }
}
