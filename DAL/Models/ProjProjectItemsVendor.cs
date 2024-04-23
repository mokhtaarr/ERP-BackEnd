using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjectItemsVendor
    {
        public int ProjectItemsVendorId { get; set; }
        public int? ProjectItemsId { get; set; }
        public int? VendorId { get; set; }
        public byte? VendorRate { get; set; }

        public virtual ProjProjectItem? ProjectItems { get; set; }
        public virtual MsVendor? Vendor { get; set; }
    }
}
