using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttendLogin
    {
        public int? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? Dateat { get; set; }
        public DateTime? ActualLoginDate { get; set; }
        public TimeSpan? LogInTime { get; set; }
        public int? RolId { get; set; }
        public string? Moderol { get; set; }
        public decimal? Countleate { get; set; }
        public decimal? Countearly { get; set; }
    }
}
