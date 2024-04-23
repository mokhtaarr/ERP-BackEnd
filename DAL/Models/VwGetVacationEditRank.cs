using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetVacationEditRank
    {
        public long? RowRank { get; set; }
        public int VacationEditDocId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
