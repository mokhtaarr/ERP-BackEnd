using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttend2
    {
        public DateTime? ActualDate { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? LogInTime { get; set; }
        public TimeSpan? LogOutTime { get; set; }
        public bool? DayType { get; set; }
        public string? ShiftName { get; set; }
        public string ShiftDay { get; set; } = null!;
        public string? Ip { get; set; }
        public string? Namedev { get; set; }
    }
}
