using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemCardVendor
    {
        public int ItemVendorId { get; set; }
        public int? ItemCardId { get; set; }
        public int? VendorId { get; set; }
    }
}
