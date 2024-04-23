using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GUserGroup
    {
        public int UserGroupId { get; set; }
        public string? UserGroupCode { get; set; }
        public string? UserGroupName1 { get; set; }
        public string? UserGroupName2 { get; set; }
        public int? ParentUserGroupId { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
