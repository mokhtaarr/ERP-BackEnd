using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RepairJobOrderComment
    {
        public int RepairCommentsId { get; set; }
        public int? RepairId { get; set; }
        public int? EmpIdComBy { get; set; }
        public string? Comment { get; set; }

        public virtual RepairJobOrder? Repair { get; set; }
    }
}
