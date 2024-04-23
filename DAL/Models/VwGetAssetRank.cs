using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetAssetRank
    {
        public long? RowRank { get; set; }
        public int AssetId { get; set; }
        public string? AssetCode { get; set; }
    }
}
