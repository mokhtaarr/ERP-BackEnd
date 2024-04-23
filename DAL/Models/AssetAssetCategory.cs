using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AssetAssetCategory
    {
        public AssetAssetCategory()
        {
            AssetAssetCards = new HashSet<AssetAssetCard>();
            InverseParentAssetCat = new HashSet<AssetAssetCategory>();
        }

        public int AssetCatId { get; set; }
        public string? CatCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? ParentAssetCatId { get; set; }
        public byte? AssetCatType { get; set; }
        public int? AssetCatLevel { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual AssetAssetCategory? ParentAssetCat { get; set; }
        public virtual ICollection<AssetAssetCard> AssetAssetCards { get; set; }
        public virtual ICollection<AssetAssetCategory> InverseParentAssetCat { get; set; }
    }
}
