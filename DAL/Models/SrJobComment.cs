using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrJobComment
    {
        public int JobComentId { get; set; }
        public int? JorderId { get; set; }
        public int? EmpIdComBy { get; set; }
        public string? Comment { get; set; }

        public virtual SrJobOrder? Jorder { get; set; }
    }
}
