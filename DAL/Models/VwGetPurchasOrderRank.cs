using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetPurchasOrderRank
    {
        public long? RowRank { get; set; }
        public int PurOrderId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
