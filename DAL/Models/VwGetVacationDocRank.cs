using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetVacationDocRank
    {
        public long? RowRank { get; set; }
        public int VacationDocId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
