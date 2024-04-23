using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemPricintDetail
    {
        public int ItemPricintDetailId { get; set; }
        public int ItemPricintId { get; set; }
        public int? ItemCardId { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? PurchDisc { get; set; }
        public decimal? FirstPrice { get; set; }
        public decimal? SecandPrice { get; set; }
        public decimal? ThirdPrice { get; set; }
        public decimal? LargePrice { get; set; }
        public decimal? Price5 { get; set; }
        public decimal? Price6 { get; set; }
        public decimal? Price7 { get; set; }
        public decimal? Price8 { get; set; }
        public decimal? Price9 { get; set; }
        public decimal? Price10 { get; set; }
        public decimal? NewPrice1 { get; set; }
        public decimal? NewPrice2 { get; set; }
        public decimal? NewPrice3 { get; set; }
        public decimal? NewPrice4 { get; set; }
        public decimal? NewPrice5 { get; set; }
        public decimal? NewPrice6 { get; set; }
        public decimal? NewPrice7 { get; set; }
        public decimal? NewPrice8 { get; set; }
        public decimal? NewPrice9 { get; set; }
        public decimal? NewPrice10 { get; set; }

        public virtual MsItemPricing ItemPricint { get; set; } = null!;
    }
}
