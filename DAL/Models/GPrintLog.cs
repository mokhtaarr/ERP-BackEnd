using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GPrintLog
    {
        public int PrintLogId { get; set; }
        public int? UserId { get; set; }
        public DateTime? PrintTime { get; set; }
        public string? DocName { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
    }
}
