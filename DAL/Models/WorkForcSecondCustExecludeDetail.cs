using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcSecondCustExecludeDetail
    {
        public int ExecludPassId { get; set; }
        public int? ScndExecludId { get; set; }
        public int? WfpassPortId { get; set; }
        public string? Remarks { get; set; }

        public virtual WorkForcSecondCustExeclude? ScndExeclud { get; set; }
    }
}
