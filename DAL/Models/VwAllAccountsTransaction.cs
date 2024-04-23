using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAllAccountsTransaction
    {
        public int PostQueId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsHelpAcc { get; set; }
        public string? HelpAccType { get; set; }
        public int? HelpAccId { get; set; }
        public int? TermId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public decimal? DebitLocal { get; set; }
        public decimal? CreditLocal { get; set; }
        public decimal? DebitCurrency { get; set; }
        public decimal? CreditCurrency { get; set; }
        public bool? IsPosted { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountNameA { get; set; }
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        public decimal? OpenningBalanceCreditCurncy { get; set; }
        public decimal? OpenningBalanceDepit { get; set; }
        public decimal? OpenningBalanceCredit { get; set; }
        public decimal? AccCurrTrancDepit { get; set; }
        public decimal? AccTotaCredit { get; set; }
        public decimal? BalanceDebitLocal { get; set; }
        public decimal? BalanceCreditLocal { get; set; }
        public decimal? AccCurrTrancDepitCurncy { get; set; }
        public decimal? AccCurrTrancCreditCurncy { get; set; }
        public decimal? AccTotalDebitCurncy { get; set; }
        public decimal? AccTotaCreditCurncy { get; set; }
        public decimal? BalanceDebitCurncy { get; set; }
        public decimal? BalanceCreditCurncy { get; set; }
        public int? CustomerId { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public string? CurrencyDescA { get; set; }
        public decimal? AccTotalDebit { get; set; }
        public string? Remarks { get; set; }
        public decimal? BalanceLocalAfterDebit { get; set; }
        public decimal? BalanceLocalAfterCredit { get; set; }
        public decimal? BalanceCurrencyAfterDebit { get; set; }
        public decimal? BalanceCurrencyAfterCredit { get; set; }
        public bool? IsOpenning { get; set; }
        public bool? CalcMethod { get; set; }
        public bool? DefualtCurrency { get; set; }
        public string? PrefixCode { get; set; }
        public string? BookNameAr { get; set; }
        public string? DocTrNo { get; set; }
        public bool? IsOpenningTerm { get; set; }
        public int? AccountCurrencyId { get; set; }
        public byte? AccountBranching { get; set; }
        public byte? AccountGroup { get; set; }
        public byte? AccountNature { get; set; }
        public byte? AccCashFlow { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public long? ChrtAccountCode { get; set; }
        public string Idname { get; set; } = null!;
        public string SourcTyp { get; set; } = null!;
        public string? SourceCode { get; set; }
        public string? SourceName { get; set; }
        public string? RemarksA { get; set; }
        public string? AnalizCode { get; set; }
        public string? AnalizName1 { get; set; }
        public string? AnalizName2 { get; set; }
        public string? CheckNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public int? ShiftId { get; set; }
        public string? CreatedBy { get; set; }
        public string? ManualTrNo { get; set; }
        public int? StoreId { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreDescA { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
        public int? DetailedTableEntityId { get; set; }
        public string? DetailedJournalDescription { get; set; }
    }
}
