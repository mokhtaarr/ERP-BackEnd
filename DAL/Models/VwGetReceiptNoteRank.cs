using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetReceiptNoteRank
    {
        public long? RowRank { get; set; }
        public int RectId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
