using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemCardDefaulPartition
    {
        public int ItemStorePrtId { get; set; }
        public int? ItemCardId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
    }
}
