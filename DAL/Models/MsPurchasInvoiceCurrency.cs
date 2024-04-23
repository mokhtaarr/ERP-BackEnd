using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPurchasInvoiceCurrency
    {
        public int PurInvCurId { get; set; }
        public int? PurInvId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        public decimal? Value { get; set; }
        public decimal? Count { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }

        public virtual MsPurchasInvoice? PurInv { get; set; }
    }
}
