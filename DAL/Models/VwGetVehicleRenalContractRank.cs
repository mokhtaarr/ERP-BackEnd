using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetVehicleRenalContractRank
    {
        public long? RowRank { get; set; }
        public int VrentContractId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
