using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdEquipProfile
    {
        public int EquipProfileId { get; set; }
        public string? ProfileCode { get; set; }
        public int? EquipId { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? ProdileDesc { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ProdEquipment? Equip { get; set; }
    }
}
