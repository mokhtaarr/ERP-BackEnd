using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCusromerUser
    {
        public int CustUserId { get; set; }
        public int? CustomerId { get; set; }
        public int? UserId { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual MsCustomer? Customer { get; set; }
        public virtual GUser? User { get; set; }
    }
}
