using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPaymentNoteCurrency
    {
        public int PayCurId { get; set; }
        public int? PayId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        public decimal? Value { get; set; }
        public decimal? Count { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }

        public virtual MsPaymentNote? Pay { get; set; }
    }
}
