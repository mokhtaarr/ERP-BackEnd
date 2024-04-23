using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrJobFile
    {
        public int FileId { get; set; }
        public int? JorderId { get; set; }
        public string? FileName { get; set; }
        public string? FileDesc { get; set; }
        public byte[]? Image { get; set; }
        public byte[]? Binary { get; set; }

        public virtual SrJobOrder? Jorder { get; set; }
    }
}
