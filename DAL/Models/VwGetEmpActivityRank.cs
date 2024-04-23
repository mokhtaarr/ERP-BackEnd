using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetEmpActivityRank
    {
        public long? RowRank { get; set; }
        public int EmpActivityId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
