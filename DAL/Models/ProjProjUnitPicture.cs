using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjUnitPicture
    {
        public int ProjUnitPictureId { get; set; }
        public Guid Fsid { get; set; }
        public int? ProjUnitId { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? AttachPath { get; set; }
        public byte[]? Fdata { get; set; }

        public virtual ProjProjUnit? ProjUnit { get; set; }
    }
}
