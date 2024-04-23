using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCurrencyCategory
    {
        public MsCurrencyCategory()
        {
            MsCurrencyCategoryJoins = new HashSet<MsCurrencyCategoryJoin>();
        }

        public int CurrencyCategoryId { get; set; }
        public string? Code { get; set; }
        public string? CurrencyCategoryNameA { get; set; }
        public string? CurrencyCategoryNameE { get; set; }
        public int? Aid { get; set; }
        public decimal? Value { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<MsCurrencyCategoryJoin> MsCurrencyCategoryJoins { get; set; }
    }
}
