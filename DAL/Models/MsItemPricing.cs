using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemPricing
    {
        public MsItemPricing()
        {
            MsItemPricintDetails = new HashSet<MsItemPricintDetail>();
        }

        public int ItemPricintId { get; set; }
        public int Code { get; set; }
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public int? Aid { get; set; }
        public bool? IsActive { get; set; }
        public int? CodingStoreId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? BrandId { get; set; }
        public int? GradId { get; set; }
        public int? GramTypeId { get; set; }
        public int? SizeTypeId { get; set; }
        public int? CoverTypeId { get; set; }
        public int? ClosingId { get; set; }
        public int? BreakTypeId { get; set; }
        public int? BoxTypeId { get; set; }
        public int? CutterTypeId { get; set; }
        public int? DistributId { get; set; }
        public int? FaceTypeId { get; set; }
        public int? GofferId { get; set; }
        public int? IndistryId { get; set; }
        public int? PadingTypeId { get; set; }
        public int? AnTypeId { get; set; }
        public int? ItemCategoryId { get; set; }
        public DateTime? DueDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }

        public virtual ICollection<MsItemPricintDetail> MsItemPricintDetails { get; set; }
    }
}
