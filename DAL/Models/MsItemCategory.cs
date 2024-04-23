using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemCategory
    {
        public MsItemCategory()
        {
            MsItemCards = new HashSet<MsItemCard>();
        }

        public int ItemCategoryId { get; set; }
        public string ItemCatCode { get; set; } = null!;
        public string? ItemCatDescA { get; set; }
        public string? ItemCatDescE { get; set; }
        public int? ParentItemCategoryId { get; set; }
        public byte? ItemCategoryType { get; set; }
        public int? ItemCategoryCatLevel { get; set; }
        public byte[]? CategoryImage { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? CurrentTrNo { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<MsItemCard> MsItemCards { get; set; }
    }
}
