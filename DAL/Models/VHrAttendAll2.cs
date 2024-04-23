using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttendAll2
    {
        public int? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? LogInTime { get; set; }
        public TimeSpan? LogOutTime { get; set; }
        public decimal? Countleate { get; set; }
        public decimal? Countearlypure { get; set; }
        public decimal? Countovertim { get; set; }
        public decimal? Countearly { get; set; }
        public int? RolId { get; set; }
    }
}
