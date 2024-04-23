using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetVehicleJobOrderRank
    {
        public long? RowRank { get; set; }
        public int VjorderId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
