using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsStockRecriptExpense
    {
        public int StockRecExpenseId { get; set; }
        public int? StockRecId { get; set; }
        public int? ExpensesId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ValueCurrency { get; set; }
        public decimal? ValueAfterRate { get; set; }
        public string? Remarks { get; set; }
        public int? CreditAccountId { get; set; }

        public virtual MsStockRecript? StockRec { get; set; }
    }
}
