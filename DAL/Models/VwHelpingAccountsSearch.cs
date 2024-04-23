using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwHelpingAccountsSearch
    {
        public string? AccountCode { get; set; }
        public string? AccountNameA { get; set; }
        public string CustVendDesc { get; set; } = null!;
        public decimal? OpenningBalanceDepit { get; set; }
        public decimal? OpenningBalanceCredit { get; set; }
        public decimal? AccCurrTrancDepit { get; set; }
        public decimal? AccCurrTrancCredit { get; set; }
        public string CustVendDesc2 { get; set; } = null!;
        public string? AccountDescription { get; set; }
    }
}
