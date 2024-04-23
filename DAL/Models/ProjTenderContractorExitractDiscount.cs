using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderContractorExitractDiscount
    {
        public int ContractorExitractDiscId { get; set; }
        public int? ContractorExitractId { get; set; }
        public int? AccountId { get; set; }
        public string? HelpAccType { get; set; }
        public bool? Accomulative { get; set; }
        public decimal? PreviousValue { get; set; }
        public decimal? DiscPercent { get; set; }
        public decimal? DiscValu { get; set; }
        public decimal? AccomulativeValue { get; set; }
        public decimal? AccomulativePercent { get; set; }
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
        public decimal? PreviousValueAfterRate { get; set; }
        public decimal? DiscValuAfterRate { get; set; }
        public decimal? AccomulativeValueAfterRate { get; set; }

        public virtual ProjTenderContractorExitract? ContractorExitract { get; set; }
    }
}
