using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetKeeperBankRank
    {
        public long? RowRank { get; set; }
        public int KeeperId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
