using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalAssetAccount
    {
        public int AssetAccountId { get; set; }
        public int? AccountId { get; set; }
        public int? AssetId { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountNameA { get; set; }
        public string? AccountNameE { get; set; }
        public bool? AccountStopped { get; set; }
        /// <summary>
        /// discount, tax, master ...etc
        /// </summary>
        public string? AccountModel { get; set; }
        public string? RemarksA { get; set; }
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
        public bool? IsPrimeAccount { get; set; }
        public bool? IsInUse { get; set; }
        public string? AccountDescription { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual AssetAssetCard? Asset { get; set; }
    }
}
