using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetSalesOfferRank
    {
        public long? RowRank { get; set; }
        public int SalesOfferId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
