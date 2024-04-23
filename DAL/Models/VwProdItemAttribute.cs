using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwProdItemAttribute
    {
        public int ItemCardId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public int AttributId { get; set; }
        public string? AttributName1 { get; set; }
        public string? AttributName2 { get; set; }
        public int? BasUnitId { get; set; }
        public string? UnitCode { get; set; }
        public string? UnitNam { get; set; }
        public string? UnitNameE { get; set; }
        public decimal? UnittRate { get; set; }
        public string? Symbol { get; set; }
        public int? ParentUnit { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsMandatory { get; set; }
        public string? AttributCode { get; set; }
    }
}
