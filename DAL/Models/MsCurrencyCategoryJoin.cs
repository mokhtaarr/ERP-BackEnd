using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCurrencyCategoryJoin
    {
        public int CurrencyCatJoinId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CurrencyCategoryId { get; set; }
        public byte? CurrencyType { get; set; }

        public virtual MsCurrency? Currency { get; set; }
        public virtual MsCurrencyCategory? CurrencyCategory { get; set; }
    }
}
