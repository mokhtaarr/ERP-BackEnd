using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttendLogOut
    {
        public int? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? LogOutDateTime { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? LogOutTime { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? RolId { get; set; }
        public string? Moderol { get; set; }
        public int Id { get; set; }
        public decimal? Countovertim { get; set; }
        public decimal? Countearlypure { get; set; }
    }
}
