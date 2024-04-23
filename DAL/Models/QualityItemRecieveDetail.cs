using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QualityItemRecieveDetail
    {
        public int ProdItemRecDetailId { get; set; }
        public int? ProdItemRecId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? ExecutedQtyBeforRate { get; set; }
        public decimal? ExecutedQty { get; set; }
        public decimal? MissedQtyBeforRate { get; set; }
        public decimal? MissedQuantity { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks2 { get; set; }

        public virtual QualityItemRecieve? ProdItemRec { get; set; }
    }
}
