using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrAttendop
    {
        public int Id { get; set; }
        public int? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? Timeat { get; set; }
        public int? Mode { get; set; }
        public int? DevId { get; set; }
    }
}
