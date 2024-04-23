using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcFirstCustExecludeDetail
    {
        public int ExecludPassId { get; set; }
        public int? ExecludId { get; set; }
        public int? WfpassPortId { get; set; }
        public string? Remarks { get; set; }

        public virtual WorkForcFirstCustExeclude? Execlud { get; set; }
    }
}
