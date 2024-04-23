using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrmSurveyMemberJoin
    {
        public int SurveyVisitId { get; set; }
        public int? SurveyId { get; set; }
        public int? TeamMemberId { get; set; }
    }
}
