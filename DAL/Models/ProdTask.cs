using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdTask
    {
        public ProdTask()
        {
            ProdJoinTaskEquipments = new HashSet<ProdJoinTaskEquipment>();
            ProdJoinTaskJobs = new HashSet<ProdJoinTaskJob>();
            ProjProjItemEmpTaskJoins = new HashSet<ProjProjItemEmpTaskJoin>();
        }

        public int TaskId { get; set; }
        public string? TaskCode { get; set; }
        public string? TaskName1 { get; set; }
        public string? TaskName2 { get; set; }
        public string? TaskDesc { get; set; }
        public string? Remarks { get; set; }
        public string? Comment { get; set; }
        public int? PurOrderId { get; set; }
        public byte? OperationType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? Duration { get; set; }

        public virtual ICollection<ProdJoinTaskEquipment> ProdJoinTaskEquipments { get; set; }
        public virtual ICollection<ProdJoinTaskJob> ProdJoinTaskJobs { get; set; }
        public virtual ICollection<ProjProjItemEmpTaskJoin> ProjProjItemEmpTaskJoins { get; set; }
    }
}
