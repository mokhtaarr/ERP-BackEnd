using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetHrTerminationRank
    {
        public long? RowRank { get; set; }
        public int TerminateId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
