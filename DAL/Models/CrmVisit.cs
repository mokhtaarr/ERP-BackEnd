using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrmVisit
    {
        public CrmVisit()
        {
            CrmVisitSurveys = new HashSet<CrmVisitSurvey>();
        }

        public int VisitId { get; set; }
        public int? VisitTypeId { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? TeamMemberId { get; set; }
        public int? LeadId { get; set; }
        public bool? LeadGetBounus { get; set; }
        public string? BounusDesc { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual CrmVisitType? VisitType { get; set; }
        public virtual ICollection<CrmVisitSurvey> CrmVisitSurveys { get; set; }
    }
}
