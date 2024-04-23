using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetItemStockAdjustmentRank
    {
        public long? RowRank { get; set; }
        public int StockAdjustId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
