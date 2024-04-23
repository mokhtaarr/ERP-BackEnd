using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetSalaryIssueDocRank
    {
        public long? RowRank { get; set; }
        public int SalaryIssuDocId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
