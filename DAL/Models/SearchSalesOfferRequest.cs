using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchSalesOfferRequest
    {
        public int SalesOfferReqId { get; set; }
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int? EmpId { get; set; }
    }
}
