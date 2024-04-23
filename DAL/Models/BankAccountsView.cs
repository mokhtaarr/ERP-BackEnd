using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BankAccountsView
    {
        public int BoxCurrencyId { get; set; }
        public string? AcountCode { get; set; }
        public string? AcounntNameA { get; set; }
        public string BoxCode { get; set; } = null!;
        public string? Desca { get; set; }
    }
}
