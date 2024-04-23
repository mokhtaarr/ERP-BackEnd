using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemCardOffer
    {
        public int OfferItemId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? BasicQuantity { get; set; }
        public int? GiftItemCardId { get; set; }
        public int? GiftUnitId { get; set; }
        public decimal? GiftQuantity { get; set; }
        public bool? IsGiftDiscount { get; set; }
        public decimal? GiftDiscount { get; set; }
        public bool? IsDiscountPercent { get; set; }
        public decimal? PriceAfterDisc { get; set; }
        public bool? IsReplace { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
    }
}
