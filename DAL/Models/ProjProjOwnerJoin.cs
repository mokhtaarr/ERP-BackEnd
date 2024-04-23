using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjOwnerJoin
    {
        public int ProjOwnerJoinId { get; set; }
        public int? ProjectId { get; set; }
        public int? ResourceId { get; set; }
        public byte? ResourceType { get; set; }
        public int? ResourceAccountId { get; set; }
        public int? HelpAccId { get; set; }
        public string? HelpAccType { get; set; }
        public string? AccountDescription { get; set; }
        public decimal? ShareValue { get; set; }
        public decimal? SharePercent { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual ProjProject? Project { get; set; }
    }
}
