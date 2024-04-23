using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPurchOrderReqDetail
    {
        public int OrderDetailItemReqId { get; set; }
        public int? PurOrderReqId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? FollowCollectionId { get; set; }
        public int? ItemIdToFollow { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public int? TaxesId1 { get; set; }
        public byte? Tax1Style { get; set; }
        public bool? Tax1IsAccomulative { get; set; }
        public bool? Tax1PlusOrMinus { get; set; }
        public decimal? Tax1Percent { get; set; }
        public decimal? TaxValue1 { get; set; }
        public int? TaxesId2 { get; set; }
        public byte? Tax2Style { get; set; }
        public bool? Tax2IsAccomulative { get; set; }
        public bool? Tax2PlusOrMinus { get; set; }
        public decimal? Tax2Percent { get; set; }
        public decimal? TaxValue2 { get; set; }
        public int? TaxesId3 { get; set; }
        public byte? Tax3Style { get; set; }
        public bool? Tax3IsAccomulative { get; set; }
        public bool? Tax3PlusOrMinus { get; set; }
        public decimal? Tax3Percent { get; set; }
        public decimal? TaxValue3 { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
        public string? BatchNumberFifoOrLifo { get; set; }
        public decimal? QtyExecuted { get; set; }
        public decimal? QtyExecutedBeforRate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceAfterRate { get; set; }
        public decimal? DisAmount { get; set; }
        public decimal? DisPercent { get; set; }
        public decimal? DisAmountAfterRate { get; set; }
        public decimal? MainDiscPercent { get; set; }
        public decimal? MainDiscValue { get; set; }
        public decimal? TaxableValue { get; set; }
        public bool? IsCollection { get; set; }
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
        public bool? PriceIncludTaxInPurch { get; set; }
        public decimal? QtyIunit2 { get; set; }
        public decimal? ServicePrice { get; set; }
        public decimal? ProfitPrice { get; set; }

        public virtual MsPurchasOrderRequest? PurOrderReq { get; set; }
    }
}
