using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrJobSpart
    {
        public int JobSpareId { get; set; }
        public int? JorderId { get; set; }
        public int? ItemCardId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Spvalue { get; set; }
        public string? Spdescription { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }

        public virtual SrJobOrder? Jorder { get; set; }
    }
}
