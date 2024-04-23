using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsBoxCurrency
    {
        public int BoxCurrencyId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BoxId { get; set; }
        public int? AccountId { get; set; }
        public int? AccountChrtId { get; set; }
        public int? RetAccountId { get; set; }
        public int? BankExpensAccId { get; set; }
        public int? ChequndercollectId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual MsBankAccount? Account { get; set; }
        public virtual MsBoxBank? Box { get; set; }
        public virtual MsCurrency? Currency { get; set; }
    }
}
