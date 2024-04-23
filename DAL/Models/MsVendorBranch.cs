using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsVendorBranch
    {
        public int VendBranchId { get; set; }
        public int? VendorId { get; set; }
        public string? VendBranchCode { get; set; }
        public string? VendBranchName1 { get; set; }
        public string? VendBranchName2 { get; set; }
        public string? Remarks { get; set; }
        public int? CityId { get; set; }
        public string? Address { get; set; }

        public virtual MsVendor? Vendor { get; set; }
    }
}
