using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCurrencyDailyRateChange
    {
        public int CurrencyChangeId { get; set; }
        public DateTime? DateAndTime { get; set; }
        public int? LocalCurrencyId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? OldRate { get; set; }
        public decimal? NewRate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
