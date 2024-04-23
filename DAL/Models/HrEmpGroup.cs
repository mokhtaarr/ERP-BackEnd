using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrEmpGroup
    {
        public HrEmpGroup()
        {
            HrEmployees = new HashSet<HrEmployee>();
            InverseParent = new HashSet<HrEmpGroup>();
        }

        public int HrempGroupId { get; set; }
        public string? GroupCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? ParentId { get; set; }
        public byte? GroupType { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsManager { get; set; }

        public virtual HrEmpGroup? Parent { get; set; }
        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
        public virtual ICollection<HrEmpGroup> InverseParent { get; set; }
    }
}
