using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPosSpecialItem
    {
        public int SpecialItemCardId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public byte? ItemType { get; set; }
        public string? BarCode { get; set; }
        public int? UnitId { get; set; }
        public decimal? Price { get; set; }
        public bool? IsBonus { get; set; }
        public bool? IsCollection { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
    }
}
