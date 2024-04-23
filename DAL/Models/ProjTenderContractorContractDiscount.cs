using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderContractorContractDiscount
    {
        public int ContractorContractDiscId { get; set; }
        public int? ContractorContractId { get; set; }
        public int? AccountId { get; set; }
        public string? HelpAccType { get; set; }
        public decimal? PercentNum { get; set; }
        public decimal? DiscValu { get; set; }
        public bool? DiscFromExtract { get; set; }
        public decimal? DiscPercent { get; set; }
        public bool? AffectContract { get; set; }
        public bool? CanExceedValu { get; set; }
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
        public decimal? DiscValuAfterRate { get; set; }

        public virtual ProjTenderContractorContract? ContractorContract { get; set; }
    }
}
