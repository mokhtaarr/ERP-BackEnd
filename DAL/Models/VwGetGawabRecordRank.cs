using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetGawabRecordRank
    {
        public long? RowRank { get; set; }
        public int LetterNormId { get; set; }
        public int? TrNo { get; set; }
    }
}
