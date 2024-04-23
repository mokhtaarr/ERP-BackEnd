using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QualityItemDeliverDetail
    {
        public int ItemDeliverDetailId { get; set; }
        public int? ItemDeliverId { get; set; }
        public int? ItemRecQualityDetailId { get; set; }
        public int? ProdItemRecDetailId { get; set; }
        public int? ItemCardId { get; set; }
        public int? QualityCatId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? ExecutedQtyBeforRate { get; set; }
        public decimal? ExecutedQty { get; set; }
        public decimal? NormalCleanQtyBeforRate { get; set; }
        public decimal? DoubleCleanQtyBeforRate { get; set; }
        public decimal? MissedQtyBeforRate { get; set; }
        public decimal? MissedQuantity { get; set; }
        public decimal? MissedMachinQtyBeforRate { get; set; }
        public decimal? MissedMachinQuantity { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? PriceNormal { get; set; }
        public decimal? TotalNormal { get; set; }
        public decimal? PriceDoubleClean { get; set; }
        public decimal? TotalDoubleClean { get; set; }
        public decimal? ReturnQtyBeforRate { get; set; }
        public decimal? ReturnQuantity { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks2 { get; set; }
        public decimal? NormalQtyBeforRate { get; set; }
        public decimal? NormalQuantity { get; set; }
        public decimal? DoublCheckQtyBeforRate { get; set; }
        public decimal? DoublCheckQuantity { get; set; }
        public decimal? RejectedQtyBeforRate { get; set; }
        public decimal? RejectedQuantity { get; set; }

        public virtual QualityItemDelivery? ItemDeliver { get; set; }
    }
}
