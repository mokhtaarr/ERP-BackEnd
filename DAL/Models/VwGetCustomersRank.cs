using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetCustomersRank
    {
        public long? RowRank { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; } = null!;
    }
}
