using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LaLand
    {
        public int LandId { get; set; }
        public int? CustomerId { get; set; }
        public int? LandMainNo { get; set; }
        public int? LandInternalNo { get; set; }
        public int? StreetNo { get; set; }
        public decimal? LandSize { get; set; }
        public bool? IsResidential { get; set; }
        public bool? RightLeft { get; set; }
        public string? BasicMemeber { get; set; }

        public virtual MsCustomer? Customer { get; set; }
    }
}
