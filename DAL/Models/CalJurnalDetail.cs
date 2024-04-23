using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalJurnalDetail
    {
        public int JurnalDetailId { get; set; }
        public int? JurnalId { get; set; }
        public int? Aid { get; set; }
        public int? AccountId { get; set; }
        public int? CustAccountId { get; set; }
        public int? VendAccountId { get; set; }
        public int? EmpAccountId { get; set; }
        public int? AssetAccountId { get; set; }
        public int? BusinessPartnerAccId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        public int? CostCenterId4 { get; set; }
        public decimal? Rate { get; set; }
        public string? JurDesc { get; set; }
        public decimal? DebitCurrency { get; set; }
        public decimal? CreditCurrency { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? DebitLocal { get; set; }
        public decimal? CreditLocal { get; set; }
        public string? Remarks { get; set; }

        public virtual MsCurrency? Currency { get; set; }
        public virtual CalJurnalEntry? Jurnal { get; set; }
    }
}
