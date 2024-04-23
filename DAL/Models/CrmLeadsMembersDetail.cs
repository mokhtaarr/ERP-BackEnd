using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrmLeadsMembersDetail
    {
        public int LeadMemberDetailId { get; set; }
        public int? LeadMemberId { get; set; }
        public int? LeadId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual CrmLeadsMember? LeadMember { get; set; }
    }
}
