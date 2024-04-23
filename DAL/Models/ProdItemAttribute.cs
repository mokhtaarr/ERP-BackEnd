using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdItemAttribute
    {
        public ProdItemAttribute()
        {
            ProdAttributeValues = new HashSet<ProdAttributeValue>();
            ProdItemAttributsJoins = new HashSet<ProdItemAttributsJoin>();
        }

        public int AttributId { get; set; }
        public string? AttributCode { get; set; }
        public string? AttributName1 { get; set; }
        public string? AttributName2 { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsMandatory { get; set; }
        /// <summary>
        /// 0 without,1 length,2 width,3 Height
        /// </summary>
        public byte? Dimension { get; set; }
        public bool? IsFixedMenuValues { get; set; }
        public bool? IsOptionalWithAlarm { get; set; }
        public int? BasUnitId { get; set; }
        public byte? DataType { get; set; }
        public decimal? MinValu { get; set; }
        public decimal? MaxValu { get; set; }
        public decimal? IncrementalValu { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<ProdAttributeValue> ProdAttributeValues { get; set; }
        public virtual ICollection<ProdItemAttributsJoin> ProdItemAttributsJoins { get; set; }
    }
}
