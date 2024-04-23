using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemCard
    {
        public MsItemCard()
        {
            MsDeliverItemCards = new HashSet<MsDeliverItemCard>();
            MsItemAlternatives = new HashSet<MsItemAlternative>();
            MsItemCardDefaulPartitions = new HashSet<MsItemCardDefaulPartition>();
            MsItemCardOffers = new HashSet<MsItemCardOffer>();
            MsItemCollections = new HashSet<MsItemCollection>();
            MsItemImages = new HashSet<MsItemImage>();
            MsItemPartitions = new HashSet<MsItemPartition>();
            MsItemStartQties = new HashSet<MsItemStartQty>();
            MsItemStockAdjustmentDetails = new HashSet<MsItemStockAdjustmentDetail>();
            MsItemUnits = new HashSet<MsItemUnit>();
            MsItemVendors = new HashSet<MsItemVendor>();
            MsPurchOrderDetails = new HashSet<MsPurchOrderDetail>();
            MsPurchaseInvoiceItemCards = new HashSet<MsPurchaseInvoiceItemCard>();
            MsReturnPurchaseItems = new HashSet<MsReturnPurchaseItem>();
            MsReturnSalesItemCards = new HashSet<MsReturnSalesItemCard>();
            MsSalesInvoiceItemCards = new HashSet<MsSalesInvoiceItemCard>();
            MsSalesOfferItemCards = new HashSet<MsSalesOfferItemCard>();
            MsStockReceiptItemCards = new HashSet<MsStockReceiptItemCard>();
            MsStockTranItemCards = new HashSet<MsStockTranItemCard>();
            ProdItemAttributsJoins = new HashSet<ProdItemAttributsJoin>();
            ProdItemcardExpenses = new HashSet<ProdItemcardExpense>();
            ProdJobOrderProducts = new HashSet<ProdJobOrderProduct>();
            SrTaskItems = new HashSet<SrTaskItem>();
            SrVehicleItemCards = new HashSet<SrVehicleItemCard>();
        }

        public int ItemCardId { get; set; }
        public int? ItemCategoryId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? BasUnitId { get; set; }
        public int? TaxesId1 { get; set; }
        public bool? Tax1ForSale { get; set; }
        public bool? Tax1ForPurch { get; set; }
        /// <summary>
        /// 0 Percent , 1 value , 2 Without
        /// </summary>
        public byte? Tax1Style { get; set; }
        public decimal? Tax1Rate { get; set; }
        public bool? Tax1IsAccomulative { get; set; }
        public bool? Tax1PlusOrMinus { get; set; }
        public int? TaxesId2 { get; set; }
        public bool? Tax2ForSale { get; set; }
        public bool? Tax2ForPurch { get; set; }
        /// <summary>
        /// 0 Percent , 1 value , 2 Without
        /// </summary>
        public byte? Tax2Style { get; set; }
        public decimal? Tax2Rate { get; set; }
        public bool? Tax2IsAccomulative { get; set; }
        public bool? Tax2PlusOrMinus { get; set; }
        public int? TaxesId3 { get; set; }
        public bool? Tax3ForSale { get; set; }
        public bool? Tax3ForPurch { get; set; }
        /// <summary>
        /// 0 Percent , 1 value , 2 Without
        /// </summary>
        public byte? Tax3Style { get; set; }
        public decimal? Tax3Rate { get; set; }
        public bool? Tax3IsAccomulative { get; set; }
        public bool? Tax3PlusOrMinus { get; set; }
        /// <summary>
        /// 1  Finished product,2 Material,3 non stock Item,4 Manufactured,5 vehicle
        /// </summary>
        public byte? ItemType { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public decimal? QtyPartiation { get; set; }
        public decimal? QtyInNotebook { get; set; }
        public decimal? TotalCost { get; set; }
        public int? PurchaseNumber { get; set; }
        public decimal? LastSalePrice { get; set; }
        public decimal? BeforLastCost { get; set; }
        public decimal? LastCostManual { get; set; }
        public decimal? ManualPurchasePrice { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? CoastAverage { get; set; }
        public DateTime? LastPurchDate { get; set; }
        public decimal? FirstQty { get; set; }
        public decimal? FirstPrice { get; set; }
        public decimal? SecandQty { get; set; }
        public decimal? SecandPrice { get; set; }
        public decimal? ThridQty { get; set; }
        public decimal? ThirdPrice { get; set; }
        public decimal? LargeQty { get; set; }
        public decimal? LargePrice { get; set; }
        public decimal? Price5 { get; set; }
        public decimal? Quantity5 { get; set; }
        public decimal? Price6 { get; set; }
        public decimal? Price7 { get; set; }
        public decimal? Price8 { get; set; }
        public decimal? Price9 { get; set; }
        public decimal? Price10 { get; set; }
        public decimal? LeastSalesPrice { get; set; }
        public decimal? LeastProfitMargin { get; set; }
        public decimal? QtyInBox { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? Wheight { get; set; }
        public string? StrCustm5 { get; set; }
        public string? Remarks { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public string? AddField8 { get; set; }
        public string? AddField9 { get; set; }
        public string? AddField10 { get; set; }
        public int? ExpirPeriod { get; set; }
        /// <summary>
        /// 1 day, 2 month, 3 year
        /// </summary>
        public byte? PeriodType { get; set; }
        /// <summary>
        /// 1 day, 2 month, 3 year
        /// </summary>
        public string? OfferDesc { get; set; }
        public bool? InOffer { get; set; }
        public DateTime? OfferFromDate { get; set; }
        public DateTime? OfferToDate { get; set; }
        public bool? IsOfferDiscount { get; set; }
        public bool? IsDiscountPercent { get; set; }
        public decimal? Discount { get; set; }
        public bool? IsExpir { get; set; }
        public bool? IsAttributeItem { get; set; }
        public bool? IsCollection { get; set; }
        public bool? IsDimension { get; set; }
        public bool? IsSerialItem { get; set; }
        public bool? AllPatchesSamePrice { get; set; }
        public bool? UseSameItemAsMaterial { get; set; }
        public bool? AutoSuggestBatches { get; set; }
        public bool? CostWithDimension { get; set; }
        public byte? DimensionSalesPrice { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public decimal? ItemLimit { get; set; }
        public decimal? ItemMax { get; set; }
        public string? Length { get; set; }
        public string? Width { get; set; }
        public string? Height { get; set; }
        public string? ItemSize { get; set; }
        public string? ItemColor { get; set; }
        public string? SerialNoPrefix { get; set; }
        public int? WarantyPeriod { get; set; }
        /// <summary>
        /// 1 day,2 week, 3 month, 4 year
        /// </summary>
        public byte? WarantyPeriodType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsTempItem { get; set; }
        public int? ProductionItemUnit { get; set; }
        public bool? SpecialItemExeclud { get; set; }
        public bool? IsCommisionPercent { get; set; }
        public decimal? Commision { get; set; }
        public DateTime? CommisionEndDate { get; set; }
        public bool? IsOuterItem { get; set; }
        public bool? UseSomeSubItems { get; set; }
        public string? TaxItemCode { get; set; }
        public decimal? ServicePrice { get; set; }
        public decimal? ProfitPrice { get; set; }
        public decimal? Kirat { get; set; }
        public bool? Unit2IsMandatory { get; set; }
        public bool? UseUnit2 { get; set; }
        public string? Separator { get; set; }
        public bool? IsSalesStopped { get; set; }
        public bool? IsServerEntity { get; set; }
        public int? MainServerId { get; set; }
        public int? AnTypeId { get; set; }
        /// <summary>
        /// 1 animal, 2 food, 3 medicin
        /// </summary>
        public byte? AnimalClass { get; set; }
        public int? CodingStoreId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? BrandId { get; set; }
        public int? GradId { get; set; }
        public int? GramTypeId { get; set; }
        public int? SizeTypeId { get; set; }
        public int? CoverTypeId { get; set; }
        public int? ClosingId { get; set; }
        public int? BreakTypeId { get; set; }
        public int? BoxTypeId { get; set; }
        public int? CutterTypeId { get; set; }
        public int? DistributId { get; set; }
        public int? FaceTypeId { get; set; }
        public int? GofferId { get; set; }
        public int? IndistryId { get; set; }
        public int? PadingTypeId { get; set; }
        public bool? UsePurchDisc { get; set; }

        public virtual MsItemCategory? ItemCategory { get; set; }
        public virtual ICollection<MsDeliverItemCard> MsDeliverItemCards { get; set; }
        public virtual ICollection<MsItemAlternative> MsItemAlternatives { get; set; }
        public virtual ICollection<MsItemCardDefaulPartition> MsItemCardDefaulPartitions { get; set; }
        public virtual ICollection<MsItemCardOffer> MsItemCardOffers { get; set; }
        public virtual ICollection<MsItemCollection> MsItemCollections { get; set; }
        public virtual ICollection<MsItemImage> MsItemImages { get; set; }
        public virtual ICollection<MsItemPartition> MsItemPartitions { get; set; }
        public virtual ICollection<MsItemStartQty> MsItemStartQties { get; set; }
        public virtual ICollection<MsItemStockAdjustmentDetail> MsItemStockAdjustmentDetails { get; set; }
        public virtual ICollection<MsItemUnit> MsItemUnits { get; set; }
        public virtual ICollection<MsItemVendor> MsItemVendors { get; set; }
        public virtual ICollection<MsPurchOrderDetail> MsPurchOrderDetails { get; set; }
        public virtual ICollection<MsPurchaseInvoiceItemCard> MsPurchaseInvoiceItemCards { get; set; }
        public virtual ICollection<MsReturnPurchaseItem> MsReturnPurchaseItems { get; set; }
        public virtual ICollection<MsReturnSalesItemCard> MsReturnSalesItemCards { get; set; }
        public virtual ICollection<MsSalesInvoiceItemCard> MsSalesInvoiceItemCards { get; set; }
        public virtual ICollection<MsSalesOfferItemCard> MsSalesOfferItemCards { get; set; }
        public virtual ICollection<MsStockReceiptItemCard> MsStockReceiptItemCards { get; set; }
        public virtual ICollection<MsStockTranItemCard> MsStockTranItemCards { get; set; }
        public virtual ICollection<ProdItemAttributsJoin> ProdItemAttributsJoins { get; set; }
        public virtual ICollection<ProdItemcardExpense> ProdItemcardExpenses { get; set; }
        public virtual ICollection<ProdJobOrderProduct> ProdJobOrderProducts { get; set; }
        public virtual ICollection<SrTaskItem> SrTaskItems { get; set; }
        public virtual ICollection<SrVehicleItemCard> SrVehicleItemCards { get; set; }
    }
}
