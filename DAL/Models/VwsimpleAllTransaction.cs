using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwsimpleAllTransaction
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
        public string? AccountCode { get; set; }
        public string? AccountNameA { get; set; }
        public string? Remarks { get; set; }
        public decimal? BalanceLocalAfterDebit { get; set; }
        public decimal? BalanceLocalAfterCredit { get; set; }
        public decimal? BalanceCurrencyAfterDebit { get; set; }
        public decimal? BalanceCurrencyAfterCredit { get; set; }
        public bool? IsOpenning { get; set; }
        public bool? CalcMethod { get; set; }
        public byte? AccountBranching { get; set; }
        public byte? AccountGroup { get; set; }
        public byte? AccountNature { get; set; }
        public byte? AccCashFlow { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public long? ChrtAccountCode { get; set; }
        public string Idname { get; set; } = null!;
        public string SourcTyp { get; set; } = null!;
        public string? RemarksA { get; set; }
        public int? DetailedTableEntityId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
    }
}
