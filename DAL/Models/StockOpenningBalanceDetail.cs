using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockOpenningBalanceDetail
    {
        public int StockOpenDetailId { get; set; }
        public int? StockOpenId { get; set; }
        public int? StockId { get; set; }
        public int? StockCurrencyId { get; set; }
        public decimal? CurrencyRate { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? TotalPriceLocal { get; set; }

        public virtual StockOpenningBalance? StockOpen { get; set; }
    }
}
