using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttendShiftChange
    {
        public int? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? LogInTime { get; set; }
        public TimeSpan? LogOutTime { get; set; }
        public int? LoginRol { get; set; }
        public int? LogOutRol { get; set; }
    }
}
