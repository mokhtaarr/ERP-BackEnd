using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcTemplatesDetail
    {
        public int WftempDetailId { get; set; }
        public int WftempId { get; set; }
        public int? WfpassPortId { get; set; }

        public virtual WorkForcTemplate Wftemp { get; set; } = null!;
    }
}
