using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsSalesInvoiceCurrency
    {
        public int InvCurId { get; set; }
        public int? InvId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        public decimal? Value { get; set; }
        public decimal? Count { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }

        public virtual MsSalesInvoice? Inv { get; set; }
    }
}
