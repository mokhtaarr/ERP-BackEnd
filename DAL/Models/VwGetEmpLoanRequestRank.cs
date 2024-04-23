using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetEmpLoanRequestRank
    {
        public long? RowRank { get; set; }
        public int EmpLoanReqId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
