using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwProdItemUnit
    {
        public int ItemCardId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public int UnitId { get; set; }
        public bool? IsDefaultSale { get; set; }
        public bool? IsDefaultPurchas { get; set; }
        public int BasUnitId { get; set; }
        public string? UnitCode { get; set; }
        public string? UnitNam { get; set; }
        public string? UnitNameE { get; set; }
        public decimal? UnittRate { get; set; }
        public int? ParentUnit { get; set; }
        public string? Symbol { get; set; }
        public int? UnitMainServerId { get; set; }
        public int? ItemMainServerId { get; set; }
        public bool? CannotDevide { get; set; }
    }
}
