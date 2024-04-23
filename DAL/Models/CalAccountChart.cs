using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalAccountChart
    {
        public CalAccountChart()
        {
            CalAccChrtDailyAssists = new HashSet<CalAccChrtDailyAssist>();
            CalAccountClaasiJoins = new HashSet<CalAccountClaasiJoin>();
            CalAccountUsers = new HashSet<CalAccountUser>();
            CalCostCenterAccounts = new HashSet<CalCostCenterAccount>();
            CalEmpAccounts = new HashSet<CalEmpAccount>();
            CodDailyAssistances = new HashSet<CodDailyAssistance>();
            StockPortfolioAccounts = new HashSet<StockPortfolioAccount>();
        }

        public int AccountId { get; set; }
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
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public byte? CostCenterOption { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsServerEntity { get; set; }
        public int? MainServerId { get; set; }

        public virtual SysAnalyticalCode? AidNavigation { get; set; }
        public virtual ICollection<CalAccChrtDailyAssist> CalAccChrtDailyAssists { get; set; }
        public virtual ICollection<CalAccountClaasiJoin> CalAccountClaasiJoins { get; set; }
        public virtual ICollection<CalAccountUser> CalAccountUsers { get; set; }
        public virtual ICollection<CalCostCenterAccount> CalCostCenterAccounts { get; set; }
        public virtual ICollection<CalEmpAccount> CalEmpAccounts { get; set; }
        public virtual ICollection<CodDailyAssistance> CodDailyAssistances { get; set; }
        public virtual ICollection<StockPortfolioAccount> StockPortfolioAccounts { get; set; }
    }
}
