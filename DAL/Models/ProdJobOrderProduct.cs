using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdJobOrderProduct
    {
        public int JobProductId { get; set; }
        public int? JobOrderId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? ItemPatchPartitionId { get; set; }
        public int? ItemPartId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? DescriptionId { get; set; }
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
        public bool? IsDelivered { get; set; }
        public bool? IsProduced { get; set; }
        public decimal? ItemCostInPrcent { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? ExpensesCostInPercent { get; set; }
        public decimal? ExpensesCost { get; set; }
        public decimal? JobsCostInPercent { get; set; }
        public decimal? JobsCost { get; set; }
        public decimal? MachineCostInPercent { get; set; }
        public decimal? MachineCost { get; set; }
        public decimal? ScrapCostInPercent { get; set; }
        public decimal? ScrapCost { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public decimal? Duration { get; set; }
        public int? AnWeightRateId { get; set; }
        public int? AnWeightRateDetailId { get; set; }
        public decimal? QtyBefore { get; set; }
        public decimal? QtyAfter { get; set; }

        public virtual ProdItemAttributesBatche? ItemAtrribBatch { get; set; }
        public virtual MsItemCard? ItemCard { get; set; }
        public virtual ProdJobOrder? JobOrder { get; set; }
    }
}
