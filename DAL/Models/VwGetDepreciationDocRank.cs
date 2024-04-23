using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetDepreciationDocRank
    {
        public long? RowRank { get; set; }
        public int DeprDocId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
