using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CodLand
    {
        public CodLand()
        {
            CodLandPermitActivJoins = new HashSet<CodLandPermitActivJoin>();
            CodLandPosJoins = new HashSet<CodLandPosJoin>();
            CodLandRetainResJoins = new HashSet<CodLandRetainResJoin>();
        }

        public int LandId { get; set; }
        public int Code { get; set; }
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public int? Aid { get; set; }
        public string? LandNo { get; set; }
        public decimal? Landarea { get; set; }
        public decimal? BuildingArea { get; set; }
        public decimal? LandMeterPrice { get; set; }
        public decimal? BuildingMeterPrice { get; set; }
        public int? LandSatusId { get; set; }
        public int? LandTypeId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }

        public virtual ICollection<CodLandPermitActivJoin> CodLandPermitActivJoins { get; set; }
        public virtual ICollection<CodLandPosJoin> CodLandPosJoins { get; set; }
        public virtual ICollection<CodLandRetainResJoin> CodLandRetainResJoins { get; set; }
    }
}
