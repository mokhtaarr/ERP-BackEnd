using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetDeliverSalesInvoiceRank
    {
        public long? RowRank { get; set; }
        public int DeliverId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
