using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrAcheivedTargetDetail
    {
        public int AcheivedTargetDetailId { get; set; }
        public int? AcheivedTargetId { get; set; }
        public int? EmpId { get; set; }
        public decimal? AcheivedValue { get; set; }
        public int? PeriodTablDetailId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? TargetId { get; set; }
        public int? HrempGroupId { get; set; }
        public decimal? AcheivedPercent { get; set; }
        public decimal? DeservPercent { get; set; }
        public decimal? CommisionValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }

        public virtual HrAcheivedTarget? AcheivedTarget { get; set; }
    }
}
