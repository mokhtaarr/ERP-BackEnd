using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetReturnSalesRank
    {
        public long? RowRank { get; set; }
        public int RetSaleId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
