using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetEmpMovePromotionRank
    {
        public long? RowRank { get; set; }
        public int EmpMoveId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
