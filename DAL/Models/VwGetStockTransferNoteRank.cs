using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetStockTransferNoteRank
    {
        public long? RowRank { get; set; }
        public int TranId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
