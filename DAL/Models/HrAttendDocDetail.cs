using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrAttendDocDetail
    {
        public int AttendDocDetailsId { get; set; }
        public int? AttendDocId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? AttendDate { get; set; }
        public DateTime? DismissDate { get; set; }
        public int? ShiftId { get; set; }
        public DateTime? FirstShftFrom { get; set; }
        public DateTime? FirstShftTo { get; set; }
        public DateTime? SecondShftFrom { get; set; }
        public DateTime? SecondShftTo { get; set; }
        public DateTime? ThirdShftFrom { get; set; }
        public DateTime? ThirdShftTo { get; set; }
        public decimal? AttenDelayByMinutes { get; set; }
        public decimal? AttenDelayByHours { get; set; }
        public decimal? AttenDelayByDays { get; set; }
        public decimal? EarlyAttendByMinutes { get; set; }
        public decimal? EarlyAttendByHours { get; set; }
        public decimal? EarlyAttendByDays { get; set; }
        public decimal? EarlyLeaveByMinutes { get; set; }
        public decimal? EarlyLeaveByHours { get; set; }
        public decimal? EarlyLeaveByDays { get; set; }
        public decimal? OverTimeByMinutes { get; set; }
        public decimal? OverTimeByHours { get; set; }
        public decimal? OverTimeByDays { get; set; }
        public decimal? NetTimeByMinutes { get; set; }
        public decimal? NetTimeByHours { get; set; }
        public decimal? NetTimeByDays { get; set; }
        public int? LeavPermisionId1 { get; set; }
        public int? LeavPermisionId2 { get; set; }
        public int? LeavPermisionId3 { get; set; }
        public int? LeavPermisionId4 { get; set; }
        public int? LeavPermisionId5 { get; set; }
        public int? LeavPermisionId6 { get; set; }

        public virtual HrAttendanceDoc? AttendDoc { get; set; }
    }
}
