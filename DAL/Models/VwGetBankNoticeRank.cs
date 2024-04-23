using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetBankNoticeRank
    {
        public long? RowRank { get; set; }
        public int BankNoticId { get; set; }
        public int? BookId { get; set; }
        public int? TrNo { get; set; }
    }
}
