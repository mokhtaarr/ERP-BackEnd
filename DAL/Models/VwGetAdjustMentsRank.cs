using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetAdjustMentsRank
    {
        public long? RowRank { get; set; }
        public int AdjustId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
