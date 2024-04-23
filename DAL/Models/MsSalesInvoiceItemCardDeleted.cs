using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsSalesInvoiceItemCardDeleted
    {
        public int DelInvItemcardId { get; set; }
        public int InvItemCardId { get; set; }
        public int? InvId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? AlterToItemCardId { get; set; }
        public int? CollectToItemCardId { get; set; }
        public int? AlterTo { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? TaxesId1 { get; set; }
        public decimal? TaxValue1 { get; set; }
        public int? TaxesId2 { get; set; }
        public decimal? TaxValue2 { get; set; }
        public int? TaxesId3 { get; set; }
        public decimal? TaxValue3 { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public string? BatchNumberFifoOrLifo { get; set; }
        public string? LotNumberExpiry { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? QuantityOut { get; set; }
        public decimal? QtyOutBeforRate { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? ReturnQtyBeforRate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceAfterRate { get; set; }
        public decimal? DisAmount { get; set; }
        public decimal? DisPercent { get; set; }
        public decimal? DisAmountAfterRate { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? FifocostUnit { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? LifocostUnit { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? CoastAverageUnit { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? LastCostUnit { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
        public bool? IsBonus { get; set; }
        public bool? IsCollection { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        /// <summary>
        /// 1 Add, 0 Edit
        /// </summary>
        public bool? AddOrEditMode { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        /// <summary>
        /// 1Deleted,0 changed
        /// </summary>
        public bool? DeletedOrChanged { get; set; }
    }
}
