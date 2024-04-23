using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AssetAssetSettingDetail
    {
        public int AssetSetDetails { get; set; }
        public int? AssetSetId { get; set; }
        public int? AssetId { get; set; }
        public DateTime? DeprStartDate { get; set; }
        public decimal? UsablifeTime { get; set; }
        public decimal? ScrapValu { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }

        public virtual AssetAssetSetting? AssetSet { get; set; }
    }
}
