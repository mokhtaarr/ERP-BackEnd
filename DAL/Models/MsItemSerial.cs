using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemSerial
    {
        public int ItemSerialId { get; set; }
        public int? ItemCardId { get; set; }
        public string? Srno1 { get; set; }
        public string? Srno2 { get; set; }
        public string? Srno3 { get; set; }
        public string? Srno4 { get; set; }
        public string? Srno5 { get; set; }
        public int? PurInvId { get; set; }
        public int? RetPurchId { get; set; }
        public int? InvId { get; set; }
        public int? RetSaleId { get; set; }
        public int? StockRecId { get; set; }
        public int? DeliverId { get; set; }
        public int? TranId { get; set; }
        public int? SalesOrderId { get; set; }
        public int? StockAdjustId { get; set; }
        public int? TranReqId { get; set; }
        public int? PurInvItemCardId { get; set; }
        public int? InvItemCardId { get; set; }
        public int? DelivItemCardId { get; set; }
        public int? StockAdjustItemId { get; set; }
        public int? OrderDetailItemCardId { get; set; }
        public int? RetPurchItemCardId { get; set; }
        public int? RetItemCardId { get; set; }
        public int? StockRecItemCardId { get; set; }
        public int? TrItenCardId { get; set; }
        public int? TranReqItemCardId { get; set; }
        public DateTime? WarrantyStrtDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public bool? IsInOrOut { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string? Color { get; set; }

        public virtual MsDeliverItemCard? DelivItemCard { get; set; }
        public virtual MsSalesInvoiceItemCard? InvItemCard { get; set; }
        public virtual MsSalesOrderItemCard? OrderDetailItemCard { get; set; }
        public virtual MsPurchaseInvoiceItemCard? PurInvItemCard { get; set; }
        public virtual MsReturnSalesItemCard? RetItemCard { get; set; }
        public virtual MsReturnPurchaseItem? RetPurchItemCard { get; set; }
        public virtual MsItemStockAdjustmentDetail? StockAdjustItem { get; set; }
        public virtual MsStockReceiptItemCard? StockRecItemCard { get; set; }
        public virtual MsStockTranItemCard? TrItenCard { get; set; }
        public virtual MsStockTranItemCardReq? TranReqItemCard { get; set; }
    }
}
