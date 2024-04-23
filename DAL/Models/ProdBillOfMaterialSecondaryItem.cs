using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdBillOfMaterialSecondaryItem
    {
        public int BillSecondaryItemsId { get; set; }
        public int BillOfMaterialId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public string? BarCode { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? ProductQtyBeforRate { get; set; }
        public decimal? ProductQuantity { get; set; }
        public int? ProductionUnitId { get; set; }
        public decimal? ProductionUnitRate { get; set; }
        public decimal? SecondaryProductPercent { get; set; }
        public decimal? ProductCostPercent { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }

        public virtual ProdBillOfMaterial BillOfMaterial { get; set; } = null!;
    }
}
