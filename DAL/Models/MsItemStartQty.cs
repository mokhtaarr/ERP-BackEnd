using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemStartQty
    {
        public int StartQtyId { get; set; }
        public int? ItemCardId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? ItemPatchPartitionId { get; set; }
        public int? ItemPartId { get; set; }
        public decimal? QtyPartiation { get; set; }
        public decimal? QtyInNotebook { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
    }
}
