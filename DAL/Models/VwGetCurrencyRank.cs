using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetCurrencyRank
    {
        public long? RowRank { get; set; }
        public int CurrencyId { get; set; }
        public string CurrencyCode { get; set; } = null!;
    }
}
