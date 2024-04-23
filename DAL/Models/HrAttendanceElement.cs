using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrAttendanceElement
    {
        public int AttendElementId { get; set; }
        public string? ElementCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? UnitDescription { get; set; }
        public decimal? FixedValue { get; set; }
        public byte? ValueType { get; set; }
        public byte? ElementUsage { get; set; }
        public byte? VacationEffect { get; set; }
        public bool? EnablEditOnEmpActivity { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? Isprintable { get; set; }
        public decimal? MinMinutes { get; set; }
    }
}
