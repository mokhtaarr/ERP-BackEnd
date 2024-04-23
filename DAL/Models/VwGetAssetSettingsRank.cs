using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetAssetSettingsRank
    {
        public long? RowRank { get; set; }
        public int AssetSetId { get; set; }
        public int? BookId { get; set; }
        public int TrNo { get; set; }
    }
}
