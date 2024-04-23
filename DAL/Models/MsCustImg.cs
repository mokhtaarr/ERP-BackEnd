using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCustImg
    {
        public int CustImgId { get; set; }
        public int? CustomerId { get; set; }
        public byte[]? Image { get; set; }
        public string? ImgDesc1 { get; set; }
        public string? ImgDesc2 { get; set; }

        public virtual MsCustomer? Customer { get; set; }
    }
}
