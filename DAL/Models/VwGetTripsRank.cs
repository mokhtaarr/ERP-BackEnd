using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetTripsRank
    {
        public long? RowRank { get; set; }
        public int TripId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
