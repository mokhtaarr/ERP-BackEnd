using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdBillOfMaterial
    {
        public ProdBillOfMaterial()
        {
            ProdBillOfMaterialItems = new HashSet<ProdBillOfMaterialItem>();
            ProdBillOfMaterialSecondaryItems = new HashSet<ProdBillOfMaterialSecondaryItem>();
        }

        public int BillOfMaterialId { get; set; }
        public string? Bomcode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public string? BarCode { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? ScrapQtyBeforRate { get; set; }
        public decimal? ScrapQuantity { get; set; }
        public bool? IsScrapCost { get; set; }
        public decimal? ScrapCostPercent { get; set; }
        public decimal? OverflowQtyBeforRate { get; set; }
        public decimal? OverflowQuantity { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsService { get; set; }
        public decimal? Duration { get; set; }
        public bool? IsReserved { get; set; }

        public virtual ICollection<ProdBillOfMaterialItem> ProdBillOfMaterialItems { get; set; }
        public virtual ICollection<ProdBillOfMaterialSecondaryItem> ProdBillOfMaterialSecondaryItems { get; set; }
    }
}
