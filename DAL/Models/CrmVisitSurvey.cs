using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrmVisitSurvey
    {
        public int VisitSurveyId { get; set; }
        public int? VisitId { get; set; }
        public int? SurveyId { get; set; }
        public string? Answer1 { get; set; }
        public string? Answer2 { get; set; }
        public string? Answer3 { get; set; }
        public string? Answer4 { get; set; }
        public bool? AnswerYorN { get; set; }
        public string? FilePath { get; set; }

        public virtual CrmVisit? Visit { get; set; }
    }
}
