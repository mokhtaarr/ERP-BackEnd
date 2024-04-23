using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaMoror
    {
        public int MororId { get; set; }
        public string MoroCode { get; set; } = null!;
        public string? MororName { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
