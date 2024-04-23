using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrComplaint
    {
        public SrComplaint()
        {
            SrReciptionDetails = new HashSet<SrReciptionDetail>();
            SrTasks = new HashSet<SrTask>();
        }

        public int ComId { get; set; }
        public string? ComCode { get; set; }
        public string? ComName1 { get; set; }
        public string? ComName2 { get; set; }
        public string? ComDesc { get; set; }
        public string? ComSolution { get; set; }
        public string? Remarks { get; set; }
        public string? Add1 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SrReciptionDetail> SrReciptionDetails { get; set; }
        public virtual ICollection<SrTask> SrTasks { get; set; }
    }
}
