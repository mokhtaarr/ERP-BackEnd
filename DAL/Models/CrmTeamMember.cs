using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrmTeamMember
    {
        public int TeamMemberId { get; set; }
        public int? TeamId { get; set; }
        public int? StoreId { get; set; }
        public int? EmpId { get; set; }
        public string MemberCode { get; set; } = null!;
        public string? MemberName1 { get; set; }
        public string? MemberName2 { get; set; }
        public bool? IsTeamLeader { get; set; }
        public decimal? DefaultTarget { get; set; }
        public bool? IsActive { get; set; }
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        public string? Remarks { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual CrmTeam? Team { get; set; }
    }
}
