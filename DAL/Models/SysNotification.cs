using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysNotification
    {
        public int NotiFyId { get; set; }
        public int? NotifyTypeId { get; set; }
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public DateTime? NextNotify { get; set; }
        public string? NotifyMessage { get; set; }
        public bool? Closed { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public int? TableEntityDetailId { get; set; }
    }
}
