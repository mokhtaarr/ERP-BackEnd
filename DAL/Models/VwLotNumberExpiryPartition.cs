using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwLotNumberExpiryPartition
    {
        public int LotNumberExpiryId { get; set; }
        public string? LotNumberExpiry { get; set; }
        public DateTime? ProdDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public byte? PeriodType { get; set; }
        public bool? Disabled { get; set; }
        public int? ItemCardId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public byte? ItemType { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public string? PartCode { get; set; }
        public string? PartDescA { get; set; }
        public string? PartDescE { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreDescA { get; set; }
        public decimal? QtyPartiation { get; set; }
        public decimal? QtyInNotebook { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? ReservedQty { get; set; }
        public decimal? RequestedQty { get; set; }
        public decimal? SaleNotDelivered { get; set; }
        public decimal? PurNotReceived { get; set; }
        public decimal? QtyOutWithoutBalance { get; set; }
        public decimal? QtyInWithoutCost { get; set; }
        public decimal? SalesOrder { get; set; }
        public decimal? WithoutCost { get; set; }
        public long? Tversion { get; set; }
        public string? Ttype { get; set; }
        public long? MaxTversion { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public string? ItemBatchCode { get; set; }
        public string? ItemBatchName1 { get; set; }
        public string? Remark { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }
        public string? Remarks5 { get; set; }
        public string? Remarks6 { get; set; }
        public string? Remarks7 { get; set; }
    }
}
