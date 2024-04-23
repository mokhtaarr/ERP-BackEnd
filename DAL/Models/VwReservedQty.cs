using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwReservedQty
    {
        public decimal Quantity { get; set; }
        public decimal QuantityOut { get; set; }
        public decimal? Reserved { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? StoreDescA { get; set; }
    }
}
