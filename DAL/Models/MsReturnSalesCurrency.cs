using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsReturnSalesCurrency
    {
        public int RetSaleCurId { get; set; }
        public int? RetSaleId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        public decimal? Value { get; set; }
        public decimal? Count { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }

        public virtual MsReturnSale? RetSale { get; set; }
    }
}
