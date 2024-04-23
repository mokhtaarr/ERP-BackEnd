using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsVwItemBatchesQtyInStore
    {
        public string StoreCode { get; set; } = null!;
        public string? StoreDescA { get; set; }
        public string? StoreDescE { get; set; }
        public string PartCode { get; set; } = null!;
        public string? PartDescA { get; set; }
        public int? ItemCardId { get; set; }
        public decimal? QtyPartiation { get; set; }
        public decimal? QtyInNotebook { get; set; }
        public int StoreId { get; set; }
        public int StorePartId { get; set; }
        public int ItemAtrribBatchId { get; set; }
        public string? ItemBatchCode { get; set; }
        public string? ItemBatchName1 { get; set; }
    }
}
