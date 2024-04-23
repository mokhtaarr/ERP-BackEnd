using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrDepartment
    {
        public HrDepartment()
        {
            HrEmployees = new HashSet<HrEmployee>();
            InverseParent = new HashSet<HrDepartment>();
        }

        public int DepartMentId { get; set; }
        public string? DepartCode { get; set; }
        public string? DepartName1 { get; set; }
        public string? DepartName2 { get; set; }
        public string? DepartTask { get; set; }
        public string? Remarks { get; set; }
        public int? ParentId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual HrDepartment? Parent { get; set; }
        public virtual ICollection<HrEmployee> HrEmployees { get; set; }
        public virtual ICollection<HrDepartment> InverseParent { get; set; }
    }
}
