using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetPaymentNoteRank
    {
        public long? RowRank { get; set; }
        public int PayId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
