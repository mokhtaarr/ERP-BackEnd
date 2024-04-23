using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetBomrank
    {
        public long? RowRank { get; set; }
        public int BillOfMaterialId { get; set; }
        public string? Bomcode { get; set; }
    }
}
