using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BoxTran
    {
        public int BoxTranDetailId { get; set; }
        public int? BoxTranId { get; set; }
        public string? BoxFrom { get; set; }
        public string? Desca { get; set; }
        public string? BoxTo { get; set; }
        public string? Desce { get; set; }
        public decimal? Valu { get; set; }
    }
}
