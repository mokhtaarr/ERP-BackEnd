using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetSalesOrderRank
    {
        public long? RowRank { get; set; }
        public int SalesOrderId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
