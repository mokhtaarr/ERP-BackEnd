using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetWeightCardRank
    {
        public long? RowRank { get; set; }
        public int ScaleCardId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
