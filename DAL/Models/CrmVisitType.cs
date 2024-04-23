using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrmVisitType
    {
        public CrmVisitType()
        {
            CrmSurveys = new HashSet<CrmSurvey>();
            CrmVisits = new HashSet<CrmVisit>();
        }

        public int VisitTypeId { get; set; }
        public string VisitCode { get; set; } = null!;
        public string? VisitName1 { get; set; }
        public string? VisitName2 { get; set; }
        public byte? VisitPeriority { get; set; }
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

        public virtual ICollection<CrmSurvey> CrmSurveys { get; set; }
        public virtual ICollection<CrmVisit> CrmVisits { get; set; }
    }
}
