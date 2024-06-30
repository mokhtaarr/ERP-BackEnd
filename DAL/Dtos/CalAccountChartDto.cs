using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CalAccountChartDto
    {
        public int? AccountId { get; set; }
        public long? AccountCode { get; set; }
        public string? AccountNameA { get; set; }
        public string? AccountNameE { get; set; }
        public int? MainAccountId { get; set; }
        public int? AccountLevel { get; set; }
        public byte? AccountType { get; set; }
        public byte? AccountNature { get; set; }
        public byte? AccountGroup { get; set; }
        public byte? AccCashFlow { get; set; }
        public bool? CalcMethod { get; set; }
        public int? CurrencyId { get; set; }
        public int? Aid { get; set; }
        public int? AccBulkAccount { get; set; }
        public int? AccountCategory { get; set; }
        public bool? CostCentersDistribute { get; set; }
        public bool? CurrencyReevaluation { get; set; }
        public bool? AccountStopped { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public decimal? OpenningBalanceDepit { get; set; }
        public decimal? OpenningBalanceCredit { get; set; }
        public decimal? AccCurrTrancDepit { get; set; }
        public decimal? AccCurrTrancCredit { get; set; }
        public decimal? AccTotalDebit { get; set; }
        public decimal? AccTotaCredit { get; set; }
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
        public decimal? AccApproxim { get; set; }

    }
}
