using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetVacationRequestRank
    {
        public long? RowRank { get; set; }
        public int VacRequestId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
