using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCustomerType
    {
        public MsCustomerType()
        {
            MsCustomers = new HashSet<MsCustomer>();
        }

        public int CustomerTypeId { get; set; }
        public string CustomerTypeCode { get; set; } = null!;
        public string? CustomerTypeDescA { get; set; }
        public string? CustomerTypeDescE { get; set; }
        public int? CustomerTypeParent { get; set; }
        public int? CustomerTypeLevel { get; set; }
        public byte? CustomerTypeLevelType { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? CurrentTrNo { get; set; }

        public virtual ICollection<MsCustomer> MsCustomers { get; set; }
    }
}
