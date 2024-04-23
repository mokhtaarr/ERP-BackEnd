using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrContainerType
    {
        public SrContainerType()
        {
            SrTrafficLinePriceLists = new HashSet<SrTrafficLinePriceList>();
        }

        public int ContainerTypeId { get; set; }
        public int? VehicleShapeId { get; set; }
        public int? VehicleTypId { get; set; }
        public string? ContainerCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public string? UseDesc { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SrTrafficLinePriceList> SrTrafficLinePriceLists { get; set; }
    }
}
