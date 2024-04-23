using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemPartition
    {
        public int ItemPartId { get; set; }
        public int? ItemCardId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? LotNumberExpiryId { get; set; }
        public decimal? QtyPartiation { get; set; }
        public decimal? QtyInNotebook { get; set; }
        public decimal? TotalCost { get; set; }
        public int? PurchaseNumber { get; set; }
        public decimal? Fifocost { get; set; }
        public decimal? Lifocost { get; set; }
        public decimal? CoastAverage { get; set; }
        public string? BatchNumberFifoOrLifo { get; set; }
        public decimal? VarianceQty { get; set; }
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
        /// <summary>
        /// number of updates on the table
        /// </summary>
        public long? Tversion { get; set; }
        /// <summary>
        /// i for inserted, u for updated
        /// </summary>
        public string? Ttype { get; set; }
        public decimal? QtyIunit2Notebook { get; set; }
        public decimal? QtyIunit2Partiation { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
        public virtual MsPartition? StorePart { get; set; }
    }
}
