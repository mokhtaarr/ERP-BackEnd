using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsVendImg
    {
        public int VendImgId { get; set; }
        public int? VendorId { get; set; }
        public byte[]? Image { get; set; }
        public string? ImgDesc1 { get; set; }
        public string? ImgDesc2 { get; set; }

        public virtual MsVendor? Vendor { get; set; }
    }
}
