using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrAttendDocFactElement
    {
        public int FactAttendId { get; set; }
        public int? AttendDocId { get; set; }
        public int? EmpId { get; set; }
        public int? ShiftId { get; set; }
        public decimal? TotalWorkDaysPeriod { get; set; }
        public decimal? TotalWorkHoursPeriod { get; set; }
        public decimal? WorkDayShow { get; set; }
        public decimal? WorkDayNoShow { get; set; }
        public decimal? Shift1Show { get; set; }
        public decimal? Shift1NoShow { get; set; }
        public decimal? Shift2Show { get; set; }
        public decimal? Shift2NoShow { get; set; }
        public decimal? Shift3Show { get; set; }
        public decimal? Shift3NoShow { get; set; }
        public decimal? LateArrivalMinutes { get; set; }
        public decimal? LateArrivalHours { get; set; }
        public decimal? LateArrivalDays { get; set; }
        public byte? LateArrivalCount { get; set; }
        public decimal? EarlyLeaveMinutes { get; set; }
        public decimal? EarlyLeaveHours { get; set; }
        public decimal? EarlyLeaveDays { get; set; }
        public byte? EarlyLeaveCount { get; set; }
        public decimal? EarlyAttendMinutes { get; set; }
        public decimal? EarlyAttendHours { get; set; }
        public decimal? EarlyAttendDays { get; set; }
        public byte? EarlyAttendCount { get; set; }
        public decimal? WorkdayOvertimeMinutes { get; set; }
        public decimal? WorkdayOvertimeHours { get; set; }
        public decimal? WorkdayOvertimeDays { get; set; }
        public byte? WorkdayOvertimeCount { get; set; }
        public decimal? VacationOvertimeMinutes { get; set; }
        public decimal? VacationOvertimeHours { get; set; }
        public decimal? VacationOvertimeDays { get; set; }
        public byte? VacationOvertimeCount { get; set; }
        public decimal? WeekendOvertimeMinutes { get; set; }
        public decimal? WeekendOvertimeHours { get; set; }
        public decimal? WeekendOvertimeDays { get; set; }
        public byte? WeekendOvertimeCount { get; set; }
        public int? WeekEndWorkShow { get; set; }
        public decimal? WeekEndWorkMinutes { get; set; }
        public decimal? WeekEndWorkHours { get; set; }
        public decimal? WeekEndWorkDays { get; set; }
        public int? VacationWorkShow { get; set; }
        public decimal? VacationWorkMinutes { get; set; }
        public decimal? VacationWorkHours { get; set; }
        public decimal? VacationWorkDays { get; set; }

        public virtual HrAttendanceDoc? AttendDoc { get; set; }
    }
}
