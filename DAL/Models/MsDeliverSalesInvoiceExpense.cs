using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsDeliverSalesInvoiceExpense
    {
        public int DeliverIdExpenseId { get; set; }
        public int? DeliverId { get; set; }
        public int? ExpensesId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ValueCurrency { get; set; }
        public decimal? ValueAfterRate { get; set; }
        public string? Remarks { get; set; }
        public int? CreditAccountId { get; set; }

        public virtual MsDeliverSalesInvoice? Deliver { get; set; }
    }
}
