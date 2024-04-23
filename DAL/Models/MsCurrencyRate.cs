using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCurrencyRate
    {
        public int EqualCurrencyPriceId { get; set; }
        public int? CurrencyId { get; set; }
        public int? EquivalentCurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? LastModify { get; set; }

        public virtual MsCurrency? Currency { get; set; }
    }
}
