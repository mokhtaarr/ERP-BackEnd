using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsSalesDepartment
    {
        public int SalesDepId { get; set; }
        public string SalesDepCode { get; set; } = null!;
        public string? SalesDepDescA { get; set; }
        public string? SalesDepDescE { get; set; }
        public int? SalesDepParent { get; set; }
        public int? SalesDepLevel { get; set; }
        public byte? SalesDepLevelType { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
