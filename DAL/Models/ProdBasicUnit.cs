using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdBasicUnit
    {
        public ProdBasicUnit()
        {
            InverseParentUnitNavigation = new HashSet<ProdBasicUnit>();
            MsItemUnits = new HashSet<MsItemUnit>();
        }

        public int BasUnitId { get; set; }
        public string? UnitCode { get; set; }
        public string? UnitNam { get; set; }
        public string? UnitNameE { get; set; }
        public decimal? UnittRate { get; set; }
        public string? Symbol { get; set; }
        public int? ParentUnit { get; set; }
        public string? Remarks { get; set; }
        public string? AutoDesc { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? EtaxUnitCode { get; set; }
        public bool? IsKarat { get; set; }
        public bool? CannotDevide { get; set; }

        public virtual ProdBasicUnit? ParentUnitNavigation { get; set; }
        public virtual ICollection<ProdBasicUnit> InverseParentUnitNavigation { get; set; }
        public virtual ICollection<MsItemUnit> MsItemUnits { get; set; }
    }
}
