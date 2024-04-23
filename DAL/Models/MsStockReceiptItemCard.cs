using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsStockReceiptItemCard
    {
        public MsStockReceiptItemCard()
        {
            MsItemSerials = new HashSet<MsItemSerial>();
        }

        public int StockRecItemCardId { get; set; }
        public int? StockRecId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? InvItemCardId { get; set; }
        public int? RetPurchItemCardId { get; set; }
        public int? JobGoStockId { get; set; }
        public int? JobProductId { get; set; }
        public int? JobScrapId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? ScaleCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public int? BillOfMaterialId { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public string? BatchNumberFifoOrLifo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? QuantityIn { get; set; }
        public decimal? QtyInBeforRate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceAfterRate { get; set; }
        public bool? IsBonus { get; set; }
        public bool FireTriger { get; set; }
        public bool? IsCollection { get; set; }
        public decimal? ExpenseShare { get; set; }
        public decimal? ExpenseShareUnit { get; set; }
        public decimal? PriceAfterExpense { get; set; }
        public decimal? PriceAfterExpenseUnit { get; set; }
        public decimal? PriceAfterCurr { get; set; }
        public decimal? PriceAfterCurrUnit { get; set; }
        public decimal? ExpenseShareAfterCurr { get; set; }
        public decimal? ExpenseShareAfterCurrUnit { get; set; }
        public decimal? PriceAfterExpenseAfterCurr { get; set; }
        public decimal? PriceAfterExpensAfterCurrUnit { get; set; }
        public byte? Satus { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? FifocostUnit { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? LifocostUnit { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? CoastAverageUnit { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
        public int? IsNoCostDeliver { get; set; }
        public bool? DeliverNoCostExecut { get; set; }
        public int? Aid { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public string? DbtableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? DbtableId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public string? AccountTableName { get; set; }
        public byte? RectSourceType { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int? RectSourceTypeId { get; set; }
        public int? VehicleId { get; set; }
        public decimal? QtyBeforDiscount { get; set; }
        public decimal? QtyDiscount { get; set; }
        public decimal? QualityDiscount { get; set; }
        public decimal? QualityValueDisc { get; set; }
        public decimal? QtyScalDiffrence { get; set; }
        public decimal? QtyScalDiffrenceValue { get; set; }
        public decimal? QtyIunit2 { get; set; }
        public decimal? ServicePrice { get; set; }
        public decimal? ProfitPrice { get; set; }
        public decimal? Kirat { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public int? MainServerId { get; set; }
        public int? ServerUnitId { get; set; }
        public int? ServerItemCardId { get; set; }
        public int? AnimalAge { get; set; }
        public bool? IsmedicinNotify { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
        public virtual MsStockRecript? StockRec { get; set; }
        public virtual MsItemUnit? Unit { get; set; }
        public virtual ICollection<MsItemSerial> MsItemSerials { get; set; }
    }
}
