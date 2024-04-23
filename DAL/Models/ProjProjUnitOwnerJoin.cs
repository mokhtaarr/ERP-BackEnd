using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjUnitOwnerJoin
    {
        public int ProjUnitOwnerJoinId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? ResourceId { get; set; }
        public byte? ResourceType { get; set; }
        public int? ResourceAccountId { get; set; }
        public int? HelpAccId { get; set; }
        public string? HelpAccType { get; set; }
        public string? AccountDescription { get; set; }
        public decimal? ShareValue { get; set; }
        public decimal? SharePercent { get; set; }
        public bool? IsMainOwner { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual ProjProjUnit? ProjUnit { get; set; }
    }
}
