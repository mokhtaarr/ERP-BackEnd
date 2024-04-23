using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrJobAdditionalCost
    {
        public int AddCostId { get; set; }
        public int? JorderId { get; set; }
        public string? AddCostDesc { get; set; }
        public decimal? AdCostValue { get; set; }

        public virtual SrJobOrder? Jorder { get; set; }
    }
}
