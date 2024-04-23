using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemCollection
    {
        public int ItemCollectId { get; set; }
        public int? ItemCardId { get; set; }
        public int? SubItemId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public string? Remarks { get; set; }
        public bool? IsNotBasic { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
    }
}
