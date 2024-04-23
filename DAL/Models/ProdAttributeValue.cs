using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdAttributeValue
    {
        public int AttribValuId { get; set; }
        public int? AttributId { get; set; }
        public string? AttributValuName1 { get; set; }
        public string? AttributValuName2 { get; set; }
        public string? AttributValue { get; set; }
        public bool? IsActive { get; set; }
        public decimal? LengthMeter { get; set; }
        public decimal? LengthCentimeter { get; set; }
        public decimal? LengthMillimeters { get; set; }
        public decimal? WidthMeter { get; set; }
        public decimal? WidthCentimeter { get; set; }
        public decimal? WidthMillimeters { get; set; }
        public decimal? HeightMeter { get; set; }
        public decimal? HeightCentimeter { get; set; }
        public decimal? HeightMillimeters { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ProdItemAttribute? Attribut { get; set; }
    }
}
