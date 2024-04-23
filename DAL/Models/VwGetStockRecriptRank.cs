using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetStockRecriptRank
    {
        public long? RowRank { get; set; }
        public int StockRecId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
