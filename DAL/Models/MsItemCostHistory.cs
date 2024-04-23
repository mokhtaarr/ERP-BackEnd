using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemCostHistory
    {
        public int ItemCostId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public decimal? QtyPartiation { get; set; }
        public decimal? QtyInNotebook { get; set; }
        public decimal? ReservedQty { get; set; }
        public decimal? RequestedQty { get; set; }
        public decimal? SaleNotDelivered { get; set; }
        public decimal? PurNotReceived { get; set; }
        public decimal? QtyOutWithoutBalance { get; set; }
        public decimal? QtyInWithoutCost { get; set; }
        public decimal? SalesOrder { get; set; }
        public decimal? PurchaseOrder { get; set; }
        public decimal? WithoutCost { get; set; }
        public decimal? ItemLimit { get; set; }
        public decimal? ItemMax { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? CoastAverage { get; set; }
        public string? BatchNumberFifoOrLifo { get; set; }
        public string? LogType { get; set; }
        public DateTime? LogDate { get; set; }
        public string? AffectByTableName { get; set; }
        public int? AffectByTableId { get; set; }
        public decimal? DocQty { get; set; }
        public decimal? DocCost { get; set; }
    }
}
