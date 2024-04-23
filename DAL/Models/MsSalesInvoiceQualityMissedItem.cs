using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsSalesInvoiceQualityMissedItem
    {
        public int QualitySaleDelMissedId { get; set; }
        public int? ItemDeliverId { get; set; }
        public int? InvId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceAfterRate { get; set; }
        public string? EmpId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual MsSalesInvoice? Inv { get; set; }
    }
}
