using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcProblem
    {
        public int WorkForcProbId { get; set; }
        public int WfpassPortId { get; set; }
        public string Complaint { get; set; } = null!;
        public string ComplaintType { get; set; } = null!;
    }
}
