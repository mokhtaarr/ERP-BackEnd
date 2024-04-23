using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemAlternative
    {
        public int AlterId { get; set; }
        public int? ItemCardId { get; set; }
        public int? AlterItemCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public string? Remarks { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
    }
}
