using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetVendorsRank
    {
        public long? RowRank { get; set; }
        public int VendorId { get; set; }
        public string VendorCode { get; set; } = null!;
    }
}
