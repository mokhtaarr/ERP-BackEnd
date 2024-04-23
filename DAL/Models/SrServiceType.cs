using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrServiceType
    {
        public SrServiceType()
        {
            SrEmpServicTypes = new HashSet<SrEmpServicType>();
            SrJobOrders = new HashSet<SrJobOrder>();
        }

        public int SrTypId { get; set; }
        public string? SrCode { get; set; }
        public string? SrName1 { get; set; }
        public string? SrName2 { get; set; }
        public string? SrDesc { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SrEmpServicType> SrEmpServicTypes { get; set; }
        public virtual ICollection<SrJobOrder> SrJobOrders { get; set; }
    }
}
