using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsVwCustomerExcelExport
    {
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public bool? IsActive { get; set; }
        public int? CreditPeriod { get; set; }
        public decimal? CreditLimit { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Remarks { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public string? CurrencyDescA { get; set; }
        public string? CatCode { get; set; }
        public string? CatDescA { get; set; }
    }
}
