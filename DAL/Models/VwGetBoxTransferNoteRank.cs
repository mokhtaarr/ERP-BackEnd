using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetBoxTransferNoteRank
    {
        public long? RowRank { get; set; }
        public int BoxTranId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
