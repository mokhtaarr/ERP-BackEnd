using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockTransferDetail
    {
        public int StockTransferDetailId { get; set; }
        public int StockTransferId { get; set; }
        public int? StockTranTypId { get; set; }
        public int? StockId { get; set; }
        public int? Quantity { get; set; }
        public decimal? CostAverage { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? ProfitLoss { get; set; }

        public virtual StockTransfer StockTransfer { get; set; } = null!;
    }
}
