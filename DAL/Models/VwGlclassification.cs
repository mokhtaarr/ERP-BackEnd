using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGlclassification
    {
        public long? AccountCode { get; set; }
        public string? AccountNameA { get; set; }
        public string? AccountNameE { get; set; }
        public int? CurrencyId { get; set; }
        public bool? CalcMethod { get; set; }
        public byte? AccountType { get; set; }
        public byte? AccountNature { get; set; }
        public byte? AccountGroup { get; set; }
        public byte? AccCashFlow { get; set; }
        public decimal? OpenningBalanceDepit { get; set; }
        public decimal? OpenningBalanceCredit { get; set; }
        public decimal? AccCurrTrancDepit { get; set; }
        public decimal? AccCurrTrancCredit { get; set; }
        public decimal? BalanceDebitLocal { get; set; }
        public decimal? BalanceCreditLocal { get; set; }
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        public decimal? OpenningBalanceCreditCurncy { get; set; }
        public decimal? AccCurrTrancDepitCurncy { get; set; }
        public decimal? AccCurrTrancCreditCurncy { get; set; }
        public decimal? AccTotalDebitCurncy { get; set; }
        public decimal? AccTotaCreditCurncy { get; set; }
        public decimal? BalanceDebitCurncy { get; set; }
        public decimal? BalanceCreditCurncy { get; set; }
        public long? Code { get; set; }
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public byte? AccountClassType { get; set; }
        public decimal? NetBalance { get; set; }
    }
}
