using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrTask
    {
        public SrTask()
        {
            SrTaskEmps = new HashSet<SrTaskEmp>();
            SrTaskItems = new HashSet<SrTaskItem>();
        }

        public int TaskId { get; set; }
        public int? ComId { get; set; }
        public string? TaskCode { get; set; }
        public string? TaskName1 { get; set; }
        public string? TaskName2 { get; set; }
        public string? TaskDescription { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? Duration { get; set; }

        public virtual SrComplaint? Com { get; set; }
        public virtual ICollection<SrTaskEmp> SrTaskEmps { get; set; }
        public virtual ICollection<SrTaskItem> SrTaskItems { get; set; }
    }
}
