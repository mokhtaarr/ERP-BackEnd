using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSearchAllAccount
    {
        public string? AccountCode { get; set; }
        public string? AccountNameA { get; set; }
        public int? AccountLevel { get; set; }
        public bool? CalcMethod { get; set; }
        public int AccType { get; set; }
        public string AccDesc { get; set; } = null!;
        public decimal? BalanceDebitCurncy { get; set; }
        public decimal? BalanceCreditCurncy { get; set; }
        public byte? AccountType { get; set; }
        public byte? AccountNature { get; set; }
        public byte? AccountGroup { get; set; }
        public byte? AccCashFlow { get; set; }
        public string AccDesc2 { get; set; } = null!;
        public string? AccountDescription { get; set; }
        public int AccountId { get; set; }
    }
}
