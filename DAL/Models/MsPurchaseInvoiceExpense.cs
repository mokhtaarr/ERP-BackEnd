using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPurchaseInvoiceExpense
    {
        public int PurExpenseId { get; set; }
        public int? PurInvId { get; set; }
        public int? ExpensesId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ValueCurrency { get; set; }
        public decimal? ValueAfterRate { get; set; }
        public string? Remarks { get; set; }
        public int? CreditAccountId { get; set; }
        public bool? IsAdvancedPay { get; set; }
        public int? PayId { get; set; }
        public int? TaxesId1 { get; set; }
        public decimal? TaxCurrency1 { get; set; }
        public decimal? TaxAfterRate1 { get; set; }
        public bool? IsRefundableTax1 { get; set; }
        public int? TaxesId2 { get; set; }
        public decimal? TaxCurrency2 { get; set; }
        public decimal? TaxAfterRate2 { get; set; }
        public bool? IsRefundableTax2 { get; set; }
        public int? TaxesId3 { get; set; }
        public decimal? TaxCurrency3 { get; set; }
        public decimal? TaxAfterRate3 { get; set; }
        public bool? IsRefundableTax3 { get; set; }

        public virtual MsPurchasInvoice? PurInv { get; set; }
    }
}
