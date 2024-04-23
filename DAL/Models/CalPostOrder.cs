using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalPostOrder
    {
        public int PostQueId { get; set; }
        public int? AccountId { get; set; }
        public int? CostCenterId { get; set; }
        public bool? IsHelpAcc { get; set; }
        public int? HelpAccId { get; set; }
        public string? HelpAccType { get; set; }
        public bool? IsHelpCostCenter { get; set; }
        public int? HelpCostCenterId { get; set; }
        public string? HelpCostCenterType { get; set; }
        public int? TermId { get; set; }
        public int? CurrencyId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public DateTime? OriginalDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public decimal? Rate { get; set; }
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public decimal? DebitLocal { get; set; }
        public decimal? CreditLocal { get; set; }
        public decimal? OpenningBalanceDepit { get; set; }
        public decimal? OpenningBalanceCredit { get; set; }
        public decimal? BalaceLocalBeforDebit { get; set; }
        public decimal? BalaceLocalBeforCredit { get; set; }
        public decimal? BalanceLocalAfterDebit { get; set; }
        public decimal? BalanceLocalAfterCredit { get; set; }
        public decimal? DebitCurrency { get; set; }
        public decimal? CreditCurrency { get; set; }
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        public decimal? OpenningBalanceCreditCurncy { get; set; }
        public decimal? BalaceCurrencyBeforDebit { get; set; }
        public decimal? BalaceCurrencyBeforCredit { get; set; }
        public decimal? BalanceCurrencyAfterDebit { get; set; }
        public decimal? BalanceCurrencyAfterCredit { get; set; }
        public decimal? OpenBalancDepCostCentr { get; set; }
        public decimal? OpenBalancCredCostCentr { get; set; }
        public decimal? BalancLocalBeforDebCostCentr { get; set; }
        public decimal? BalancLocalBeforCredCostCentr { get; set; }
        public decimal? BalancLocalAfterDebCostCentr { get; set; }
        public decimal? BalancLocalAfterCredCostCentr { get; set; }
        public decimal? OpenBalancDepCrncyCostCentr { get; set; }
        public decimal? OpenBalancCredCrncyCostCentr { get; set; }
        public decimal? BalancCrencyBeforDebtCostCentr { get; set; }
        public decimal? BalancCrencyBeforCredCostCentr { get; set; }
        public decimal? BalancCrencyAftrDebtCostCentr { get; set; }
        public decimal? BalancCrencyAftrCredCostCentr { get; set; }
        public bool? IsPosted { get; set; }
        public int? OrderId { get; set; }
        public bool? IsOpenningTerm { get; set; }
        public int? DetailedTableEntityId { get; set; }
        public DateTime? TrDate { get; set; }
    }
}
