using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CalCostCenterDto
    {
        public int? CostCenterId { get; set; }
        public int? CostCenterCode { get; set; }
        public string? CostCenterNameA { get; set; }
        public string? CostCenterNameE { get; set; }
        public int? MainCostCenterId { get; set; }
        public int? CostCenterLevel { get; set; }
        public byte? CenterCategory { get; set; }
        public byte? CostType { get; set; }
        public byte? CashFlowList { get; set; }
        public int? Aid { get; set; }
        public int? AccountId { get; set; }
        public int? CurrencyId { get; set; }
        public string? FunctionDescA { get; set; }
        public string? FunctionDescE { get; set; }
        public decimal? PreviousBalance { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public int? Parent { get; set; }
        public int? MonthlybalanceId { get; set; }
        public byte? JopDesc { get; set; }
        public int? BoxId { get; set; }
        public int? AccCostCenterId { get; set; }
        public decimal? OpenningBalanceDepit { get; set; }
        public decimal? OpenningBalanceCredit { get; set; }
        public decimal? CostCenterCurrTrancDepit { get; set; }
        public decimal? CostCenterCurrTrancCredit { get; set; }
        public decimal? CostCenterTotalDebit { get; set; }
        public decimal? CostCenterTotaCredit { get; set; }
        public decimal? BalanceDebitLocal { get; set; }
        public decimal? BalanceCreditLocal { get; set; }
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        public decimal? OpenningBalanceCreditCurncy { get; set; }
        public decimal? CostCenterCurrTrancDepitCurncy { get; set; }
        public decimal? CostCenterCurrTrancCreditCurncy { get; set; }
        public decimal? CostCenterTotalDebitCurncy { get; set; }
        public decimal? CostCenterTotaCreditCurncy { get; set; }
        public decimal? BalanceDebitCurncy { get; set; }
        public decimal? BalanceCreditCurncy { get; set; }

    }
}
