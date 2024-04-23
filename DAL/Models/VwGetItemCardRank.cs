using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetItemCardRank
    {
        public long? RowRank { get; set; }
        public int ItemCardId { get; set; }
        public string? ItemCode { get; set; }
    }
}
