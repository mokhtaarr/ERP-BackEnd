using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PrintQoutationDetailsItem
    {
        public int PrintQoutItemId { get; set; }
        public int PrinQoutDetailId { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? TotalDimension { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }

        public virtual PrintQoutationDetail PrinQoutDetail { get; set; } = null!;
    }
}
