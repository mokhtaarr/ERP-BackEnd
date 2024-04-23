using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetPurchasInvoiceRank
    {
        public long? RowRank { get; set; }
        public int PurInvId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
