using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetAnalyticalCodeRank
    {
        public long? RowRank { get; set; }
        public int Aid { get; set; }
        public string Code { get; set; } = null!;
    }
}
