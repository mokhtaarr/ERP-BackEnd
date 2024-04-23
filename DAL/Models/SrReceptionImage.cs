using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrReceptionImage
    {
        public int RecImgId { get; set; }
        public int? ReciptionId { get; set; }
        public byte[]? Image { get; set; }
        public string? ImgDesc { get; set; }

        public virtual SrReciption? Reciption { get; set; }
    }
}
