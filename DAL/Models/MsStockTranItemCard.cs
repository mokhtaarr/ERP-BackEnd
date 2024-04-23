using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsStockTranItemCard
    {
        public MsStockTranItemCard()
        {
            MsItemSerials = new HashSet<MsItemSerial>();
        }

        public int TrItenCardId { get; set; }
        public int? TranId { get; set; }
        public int? ItemCardId { get; set; }
        public int? PartFrom { get; set; }
        public int? PartTo { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? ScaleCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public string? BatchNumberFifoOrLifo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? Value { get; set; }
        public decimal? ValueRate { get; set; }
        public bool? IsCollection { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? FifocostUnit { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? LifocostUnit { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? CoastAverageUnit { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? LastCostUnit { get; set; }
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
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
        public decimal? QtyIunit2 { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public int? MainServerId { get; set; }
        public int? ServerUnitId { get; set; }
        public int? ServerItemCardId { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
        public virtual MsStockTransferNote? Tran { get; set; }
        public virtual MsItemUnit? Unit { get; set; }
        public virtual ICollection<MsItemSerial> MsItemSerials { get; set; }
    }
}
