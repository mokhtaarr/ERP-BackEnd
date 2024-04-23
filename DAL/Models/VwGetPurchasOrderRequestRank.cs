using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetPurchasOrderRequestRank
    {
        public long? RowRank { get; set; }
        public int PurOrderReqId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
