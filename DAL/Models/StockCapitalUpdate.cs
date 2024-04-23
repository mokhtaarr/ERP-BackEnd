using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockCapitalUpdate
    {
        public int StockCapitalUpdatId { get; set; }
        public int? StockId { get; set; }
        public decimal? CurrentCapital { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? UpdateValue { get; set; }
        public decimal? SalePrice { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual StockStock? Stock { get; set; }
    }
}
