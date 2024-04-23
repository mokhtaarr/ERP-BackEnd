using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrTarget
    {
        public int TargetId { get; set; }
        /// <summary>
        /// 1 مبلغ, 2 عدد
        /// </summary>
        public byte? TargetType { get; set; }
        public decimal? TargetFrom { get; set; }
        public decimal? TargetTo { get; set; }
        public int? HrempGroupId { get; set; }
        public decimal? AcheivedPercent { get; set; }
        public decimal? DeservPercent { get; set; }
        public decimal? ManagerLevel1Percent { get; set; }
        public decimal? ManagerLevel2Percent { get; set; }
        public decimal? ManagerLevel3Percent { get; set; }
        public decimal? ManagerLevel4Percent { get; set; }
        public decimal? ManagerLevel5Percent { get; set; }
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
