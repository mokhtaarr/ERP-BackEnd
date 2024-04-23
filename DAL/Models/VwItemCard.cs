using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwItemCard
    {
        public int ItemCardId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public string? ItemType { get; set; }
        public decimal? LastSalePrice { get; set; }
        public decimal? BeforLastCost { get; set; }
        public decimal? LastCostManual { get; set; }
        public decimal? ManualPurchasePrice { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? CoastAverage { get; set; }
        public DateTime? LastPurchDate { get; set; }
        public decimal? FirstPrice { get; set; }
        public decimal? SecandPrice { get; set; }
        public decimal? ThirdPrice { get; set; }
        public decimal? LargePrice { get; set; }
        public decimal? Price5 { get; set; }
        public decimal? Price6 { get; set; }
        public bool? InOffer { get; set; }
        public bool? IsExpir { get; set; }
        public bool? IsAttributeItem { get; set; }
        public bool? IsDimension { get; set; }
        public bool? IsCollection { get; set; }
        public bool? IsSerialItem { get; set; }
        public decimal? ItemLimit { get; set; }
        public decimal? ItemMax { get; set; }
        public string? ItemCatCode { get; set; }
        public string? ItemCatDescA { get; set; }
        public string? ItemCatDescE { get; set; }
        public string? ItemType2 { get; set; }
        public int? MainServerId { get; set; }
    }
}
