using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcQueue
    {
        public int Id { get; set; }
        public string? PassportNo { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? Timeat { get; set; }
        public int? Rolnum { get; set; }
        public int? Seasonid { get; set; }
        public int? WfpassPortId { get; set; }
    }
}
