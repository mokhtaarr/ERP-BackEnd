using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VdeliverSalesInvfilter
    {
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public int InvTrNo { get; set; }
        public decimal? DeliverQtyOut { get; set; }
        public string? StrCustm4 { get; set; }
        public string? StrCustm5 { get; set; }
    }
}
