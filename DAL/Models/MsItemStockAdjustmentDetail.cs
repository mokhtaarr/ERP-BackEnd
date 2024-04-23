using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemStockAdjustmentDetail
    {
        public MsItemStockAdjustmentDetail()
        {
            MsItemSerials = new HashSet<MsItemSerial>();
        }

        public int StockAdjustItemId { get; set; }
        public int? StockAdjustId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public string? BatchNumberFifoOrLifo { get; set; }
        public decimal? NewQuantity { get; set; }
        public decimal? QtyBeforRateNew { get; set; }
        public decimal? OldQuantity { get; set; }
        public decimal? QtyBeforRateOld { get; set; }
        public decimal? DiffQuantity { get; set; }
        public decimal? DiffQtyBeforRate { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? FifocostUnit { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? LifocostUnit { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? CoastAverageUnit { get; set; }
        public decimal? FifocostOld { get; set; }
        public decimal? FifocostOldUnit { get; set; }
        public decimal? LifocostOld { get; set; }
        public decimal? LifocostOldUnit { get; set; }
        public decimal? CoastAverageOld { get; set; }
        public decimal? CoastAverageOldUnit { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? LastCostUnit { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
        public decimal? QtyIunit2 { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
        public virtual MsItemStockAdjustment? StockAdjust { get; set; }
        public virtual ICollection<MsItemSerial> MsItemSerials { get; set; }
    }
}
