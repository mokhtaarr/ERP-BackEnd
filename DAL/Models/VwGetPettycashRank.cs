using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetPettycashRank
    {
        public long? RowRank { get; set; }
        public int PettycashId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
