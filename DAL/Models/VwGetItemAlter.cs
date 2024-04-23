using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetItemAlter
    {
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public decimal? Qty { get; set; }
        public int? ItemCardId { get; set; }
        public string? AlterToCod { get; set; }
        public string? AlterToDesc { get; set; }
    }
}
