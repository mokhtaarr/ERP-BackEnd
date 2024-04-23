using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetRewardAndPenaltyRank
    {
        public long? RowRank { get; set; }
        public int RewardId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
