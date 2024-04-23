using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsBankAccount
    {
        public MsBankAccount()
        {
            MsBoxCurrencies = new HashSet<MsBoxCurrency>();
        }

        public int AccountId { get; set; }
        public string? AcountCode { get; set; }
        public string? AcounntNameA { get; set; }
        public string? AcounntNameE { get; set; }

        public virtual ICollection<MsBoxCurrency> MsBoxCurrencies { get; set; }
    }
}
