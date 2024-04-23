using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttendAllChangeshift
    {
        public int? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? LogInTime { get; set; }
        public TimeSpan? LogOutTime { get; set; }
        public int? RolId { get; set; }
        public int? DevId { get; set; }
        public string? Ip { get; set; }
        public string? Namedev { get; set; }
        public int? LoginRol { get; set; }
        public int? LogOutRol { get; set; }
    }
}
