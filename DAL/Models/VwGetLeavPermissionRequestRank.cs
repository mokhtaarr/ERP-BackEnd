using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetLeavPermissionRequestRank
    {
        public long? RowRank { get; set; }
        public int LeavPermReqId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
