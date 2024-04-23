using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VShiftDay
    {
        public int ShiftId { get; set; }
        public string? ShiftCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public bool? DayType { get; set; }
        public string ShiftDay { get; set; } = null!;
    }
}
