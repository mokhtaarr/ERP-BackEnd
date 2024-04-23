using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QualityCategory
    {
        public int QualityCatId { get; set; }
        public string Code { get; set; } = null!;
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public int? Aid { get; set; }
        public decimal? DamagDegree { get; set; }
        public bool? IsRejected { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
    }
}
