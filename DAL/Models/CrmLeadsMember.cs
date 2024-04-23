using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrmLeadsMember
    {
        public CrmLeadsMember()
        {
            CrmLeadsMembersDetails = new HashSet<CrmLeadsMembersDetail>();
            CrmLeadsMembersJoins = new HashSet<CrmLeadsMembersJoin>();
        }

        public int LeadMemberId { get; set; }
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? TeamMemberId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<CrmLeadsMembersDetail> CrmLeadsMembersDetails { get; set; }
        public virtual ICollection<CrmLeadsMembersJoin> CrmLeadsMembersJoins { get; set; }
    }
}
