using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PrintPricingDetail
    {
        public int PrinPriceIdDetailId { get; set; }
        public int? PrinPriceId { get; set; }
        public int? ItemCardId { get; set; }
        public int? GramTypeId { get; set; }
        public int? GofferId { get; set; }
        public int? ProductTypeId { get; set; }
        public byte? PartSerial { get; set; }
        public byte? Layer { get; set; }
        public decimal? Factor { get; set; }
        public decimal? GramFactor { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? TotalDimension { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Price { get; set; }
        public decimal? Materialgram { get; set; }
        public decimal? OperationPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? KnifeLength { get; set; }
        public decimal? KnifeWidth { get; set; }
        public decimal? SolfanPrice { get; set; }
        public decimal? Slofan { get; set; }
        public decimal? LayerPrice { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }

        public virtual PrintPricing? PrinPrice { get; set; }
    }
}
