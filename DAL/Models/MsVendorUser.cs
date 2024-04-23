using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsVendorUser
    {
        public int VendUserId { get; set; }
        public int? VendorId { get; set; }
        public int? UserId { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual GUser? User { get; set; }
        public virtual MsVendor? Vendor { get; set; }
    }
}
