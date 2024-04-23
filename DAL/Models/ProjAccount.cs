using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjAccount
    {
        public int ProjectAccId { get; set; }
        public int? ProjectId { get; set; }
        public int? AccountId { get; set; }
        public decimal? Value { get; set; }

        public virtual ProjProject? Project { get; set; }
    }
}
