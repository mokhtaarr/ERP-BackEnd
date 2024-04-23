using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PrintQoutationDetail
    {
        public PrintQoutationDetail()
        {
            PrintQoutationDetailsItems = new HashSet<PrintQoutationDetailsItem>();
        }

        public int PrinQoutDetailId { get; set; }
        public int PrinQoutId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? UnitRate { get; set; }
        public decimal? OuterBoxesCount { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }
        public int? ItemCardId { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }
        public int? UnitId { get; set; }
        public byte? ItemType { get; set; }
        public int? EditTypeId { get; set; }
        public byte? SizeSource { get; set; }
        public int? StockingId { get; set; }
        public int? DistributId { get; set; }
        public int? BoxTypeId { get; set; }
        public int? SectorId { get; set; }
        public int? GofferId { get; set; }
        public bool? IsDraw { get; set; }
        public bool? IsSample { get; set; }
        public decimal? PartsCount { get; set; }
        public decimal? BoxCount { get; set; }
        public int? Layers { get; set; }
        public decimal? OutOrderLength { get; set; }
        public decimal? OutOrderWidth { get; set; }
        public decimal? OutOrderHeight { get; set; }
        public decimal? InOrderLength { get; set; }
        public decimal? InOrderWidth { get; set; }
        public decimal? InOrderHeight { get; set; }
        public decimal? CutterLength { get; set; }
        public decimal? CutterWidth { get; set; }
        public decimal? CutterHeight { get; set; }
        public decimal? CutterMetricLength { get; set; }
        public decimal? GofferMetricLength { get; set; }
        public decimal? PurpuraMetricLength { get; set; }
        public decimal? TotalLength { get; set; }

        public virtual PrintQoutation PrinQout { get; set; } = null!;
        public virtual ICollection<PrintQoutationDetailsItem> PrintQoutationDetailsItems { get; set; }
    }
}
