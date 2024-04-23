using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockSalesPurchaseDetail
    {
        public int StockSalPurchDetailId { get; set; }
        public int? StockSalPurchId { get; set; }
        public int? StockTranTypId { get; set; }
        public int? StockDealersId { get; set; }
        public int? DealNo { get; set; }
        public DateTime? DealTime { get; set; }
        public int? StockId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? FixedCommision { get; set; }
        public decimal? OtherCommision { get; set; }
        public decimal? NetValue { get; set; }

        public virtual StockSalesPurchase? StockSalPurch { get; set; }
    }
}
