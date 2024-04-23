using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaCapacity
    {
        public int CapcityId { get; set; }
        public string? CapcityCode { get; set; }
        public string? CapcityDescA { get; set; }
        public string? CapcityDescE { get; set; }
        public string? Size { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
