using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsWeightcardItem
    {
        public int WeightItemId { get; set; }
        public int? ScaleCardId { get; set; }
        public int? ItemCardId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public string? BarCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? ScaleQuantity { get; set; }
        public decimal? ScaleQtyBeforRate { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public decimal? QtyIunit2 { get; set; }

        public virtual MsWeightCard? ScaleCard { get; set; }
    }
}
