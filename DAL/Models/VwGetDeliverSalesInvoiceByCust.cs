using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetDeliverSalesInvoiceByCust
    {
        public string? DocTrNo { get; set; }
        public string? PrefixCode { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? Remarks { get; set; }
        public decimal? TotalCostAverage { get; set; }
        public decimal? TotalLastCost { get; set; }
        public string IsCust { get; set; } = null!;
        public int DeliverId { get; set; }
        public int? BookId { get; set; }
        public int? StoreId { get; set; }
    }
}
