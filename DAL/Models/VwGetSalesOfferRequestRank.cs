using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetSalesOfferRequestRank
    {
        public long? RowRank { get; set; }
        public int SalesOfferReqId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
