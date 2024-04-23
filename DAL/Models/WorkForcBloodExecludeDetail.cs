using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcBloodExecludeDetail
    {
        public int ExecludPassId { get; set; }
        public int? BloodExecludId { get; set; }
        public int? WfpassPortId { get; set; }
        public string? Remarks { get; set; }
        public bool? Succeeded { get; set; }

        public virtual WorkForcBloodExeclude? BloodExeclud { get; set; }
    }
}
