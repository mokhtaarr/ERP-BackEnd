using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPettyPaymentJoin
    {
        public int PetyPayId { get; set; }
        public int? PayId { get; set; }
        public int? PettycashId { get; set; }

        public virtual MsPaymentNote? Pay { get; set; }
        public virtual MsPettycash? Pettycash { get; set; }
    }
}
