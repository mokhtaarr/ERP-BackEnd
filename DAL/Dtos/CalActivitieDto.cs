using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CalActivitieDto
    {
        public int? ActiveId { get; set; }
        public int? ActiveCode { get; set; }
        public string? ActiveNameA { get; set; }
        public string? ActiveNameE { get; set; }
        public int? mainActiveId { get; set; }
        public int? ActiveLevel { get; set; }
        public byte? ActiveCategory { get; set; }
        public byte? ActiveType { get; set; }
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
        public int? AccActiveId { get; set; }
        public decimal? OpenningBalanceDepit { get; set; }
        public decimal? OpenningBalanceCredit { get; set; }
        public decimal? ActiveCurrTrancDepit { get; set; }
        public decimal? ActiveCurrTrancCredit { get; set; }
        public decimal? ActiveTotalDebit { get; set; }
        public decimal? ActiveTotaCredit { get; set; }
        public decimal? BalanceDebitLocal { get; set; }
        public decimal? BalanceCreditLocal { get; set; }
        public decimal? OpenningBalanceDepitCurncy { get; set; }
        public decimal? OpenningBalanceCreditCurncy { get; set; }
        public decimal? ActiveCurrTrancDepitCurncy { get; set; }
        public decimal? ActiveCurrTrancCreditCurncy { get; set; }
        public decimal? ActiveTotalDebitCurncy { get; set; }
        public decimal? ActiveTotaCreditCurncy { get; set; }
        public decimal? BalanceDebitCurncy { get; set; }
        public decimal? BalanceCreditCurncy { get; set; }
    }
}
