using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAllJobOrderDocument
    {
        public string? DocTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? Docval { get; set; }
    }
}
