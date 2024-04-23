using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalAccountingFix
    {
        public int AccRecalcId { get; set; }
        public int? UserId { get; set; }
        public DateTime? TrDate { get; set; }
        public string? Reason { get; set; }
    }
}
