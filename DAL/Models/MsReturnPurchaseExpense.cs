using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsReturnPurchaseExpense
    {
        public int RetPurchExpenseId { get; set; }
        public int? RetPurchId { get; set; }
        public int? ExpensesId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ValueCurrency { get; set; }
        public decimal? ValueAfterRate { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public int? CreditAccountId { get; set; }

        public virtual MsReturnPurchase? RetPurch { get; set; }
    }
}
