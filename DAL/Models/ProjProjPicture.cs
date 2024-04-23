using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjPicture
    {
        public int ProjPictureId { get; set; }
        public Guid Fsid { get; set; }
        public int? ProjectId { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? AttachPath { get; set; }
        public byte[]? Fdata { get; set; }

        public virtual ProjProject? Project { get; set; }
    }
}
