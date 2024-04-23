using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetJournalEntryRank
    {
        public long? RowRank { get; set; }
        public int JurnalId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
