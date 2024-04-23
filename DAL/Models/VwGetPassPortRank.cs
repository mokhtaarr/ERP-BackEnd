using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetPassPortRank
    {
        public long? RowRank { get; set; }
        public int WfpassPortId { get; set; }
        public string Code { get; set; } = null!;
        public int? SeasonId { get; set; }
    }
}
