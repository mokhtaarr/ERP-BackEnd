using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderContractorContractAdd
    {
        public int ContractorContractAddId { get; set; }
        public int? ContractorContractId { get; set; }
        public int? AccountId { get; set; }
        public string? HelpAccType { get; set; }
        public bool? Accomulative { get; set; }
        public decimal? CurrentValue { get; set; }
        public decimal? CurrentPercent { get; set; }
        public decimal? AddPercent { get; set; }
        public decimal? AddValu { get; set; }
        public decimal? TotalValue { get; set; }
        public bool? AddToExitract { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }
        public int? CustAccountId { get; set; }
        public int? VendAccountId { get; set; }
        public int? EmpAccountId { get; set; }
        public int? AssetAccountId { get; set; }
        public int? BusinessPartnerAccId { get; set; }
        public decimal? Rate { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? CurrentValueAfterRate { get; set; }
        public decimal? AddValuAfterRate { get; set; }
        public decimal? TotalValueAfterRate { get; set; }

        public virtual ProjTenderContractorContract? ContractorContract { get; set; }
    }
}
