using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysLog
    {
        public long LogId { get; set; }
        public string? TablName { get; set; }
        public int? UserId { get; set; }
        public int? RowIndex { get; set; }
        public string? LogAction { get; set; }
        public DateTime? LogDate { get; set; }
        public string? ScreenName { get; set; }
        public string? ScreenNameAr { get; set; }
        public string? TablDetailName { get; set; }
        public string? FieldName { get; set; }
        public string? FieldNameAr { get; set; }
        public string? FieldDetail { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
    }
}
