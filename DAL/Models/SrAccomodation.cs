using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrAccomodation
    {
        public SrAccomodation()
        {
            SrTripAccomDetails = new HashSet<SrTripAccomDetail>();
        }

        public int AccomodationId { get; set; }
        public int? TripId { get; set; }
        public int? CityId { get; set; }
        public int? HotelId { get; set; }
        /// <summary>
        /// 1 RO,2 BB,3 HB,4 FB
        /// </summary>
        public byte? AccomodationType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Remarks { get; set; }

        public virtual SrHotel? Hotel { get; set; }
        public virtual SrTrip? Trip { get; set; }
        public virtual ICollection<SrTripAccomDetail> SrTripAccomDetails { get; set; }
    }
}
