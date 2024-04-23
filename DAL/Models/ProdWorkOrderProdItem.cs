using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdWorkOrderProdItem
    {
        public int WorkOrderProdItemId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? ItemRecQualityDetailId { get; set; }
        public int? ItemRecQualityId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? ItemPatchPartitionId { get; set; }
        public int? ItemPartId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? BillOfMaterialId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public string? BatchNumberFifoOrLifo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? QuantityOut { get; set; }
        public decimal? QtyOutBeforRate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceAfterRate { get; set; }
        public int? UnitIdEstimat { get; set; }
        public decimal? UnitRateEstimat { get; set; }
        public decimal? QuantityEstimat { get; set; }
        public decimal? QtyBeforRateEstimat { get; set; }
        public decimal? PriceEstimat { get; set; }
        public decimal? ExecutedQtyBeforRate { get; set; }
        public decimal? ExecutedQty { get; set; }
        public decimal? NormalCleanQtyBeforRate { get; set; }
        public decimal? DoubleCleanQtyBeforRate { get; set; }
        public decimal? MissedQtyBeforRate { get; set; }
        public decimal? MissedQuantity { get; set; }
        public decimal? NormalQtyBeforRate { get; set; }
        public decimal? NormalQuantity { get; set; }
        public decimal? DoublCheckQtyBeforRate { get; set; }
        public decimal? DoublCheckQuantity { get; set; }
        public decimal? RejectedQtyBeforRate { get; set; }
        public decimal? RejectedQuantity { get; set; }
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
        public decimal? Fifocost { get; set; }
        public decimal? FifocostUnit { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? LifocostUnit { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? CoastAverageUnit { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? LastCostUnit { get; set; }
        public decimal? BatchLength { get; set; }
        public decimal? BatchWidth { get; set; }
        public decimal? BatchHieght { get; set; }
        public decimal? RequestedMeter { get; set; }
        public bool? IsDelivered { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual ProdWorkOrder? WorkOrder { get; set; }
    }
}
