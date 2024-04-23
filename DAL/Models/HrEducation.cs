using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrEducation
    {
        public int EducationId { get; set; }
        public string? EducationCode { get; set; }
        public string? EducationName1 { get; set; }
        public string? EducationName2 { get; set; }
        public string? EducationDesc { get; set; }
        public string? Qualification { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
