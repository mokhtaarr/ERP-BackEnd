using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetProductionOrdeRank
    {
        public long? RowRank { get; set; }
        public int ProductionOrderId { get; set; }
        public int TrNo { get; set; }
    }
}
