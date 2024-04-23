using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GUserScreenField
    {
        public int ScreenFieldId { get; set; }
        public int? UserModuleId { get; set; }
        public int? UserId { get; set; }
        public int? UserGroupId { get; set; }
        public string? FieldName { get; set; }
        public string? AuthDesc { get; set; }
        public bool? Authinticated { get; set; }
        public int? AuthenticatedBy { get; set; }
    }
}
