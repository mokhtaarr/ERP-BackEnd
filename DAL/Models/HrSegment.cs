using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrSegment
    {
        public int SegmentId { get; set; }
        public int? SalaryTypId { get; set; }
        public byte? SegmentSerial { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public decimal? FromSegmant { get; set; }
        public decimal? ToSegmant { get; set; }
        public decimal? SegmantPercent { get; set; }
        public string? Remarks { get; set; }

        public virtual HrSalaryType? SalaryTyp { get; set; }
    }
}
