using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjUnitHistoryLog
    {
        public int ProjUnitHistoryId { get; set; }
        public int? ProjUnitId { get; set; }
        public string? TableCode { get; set; }
        public string? TableEntityIdName { get; set; }
        public long? TableEntityId { get; set; }
        public string? LogActionDesc { get; set; }
        public string? Remarks { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
