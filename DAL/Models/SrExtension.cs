using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrExtension
    {
        public int ExtensionId { get; set; }
        public int? TripId { get; set; }
        public int? CityId { get; set; }
        public int? HotelId { get; set; }
        /// <summary>
        /// single, double, Trible
        /// </summary>
        public byte? Number { get; set; }
        public decimal? Price { get; set; }

        public virtual MsgaCity? City { get; set; }
        public virtual SrHotel? Hotel { get; set; }
        public virtual SrTrip? Trip { get; set; }
    }
}
