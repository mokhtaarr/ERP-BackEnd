using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CodSubRegion
    {
        public int SubRegionClassId { get; set; }
        public int Code { get; set; }
        public string? NameA { get; set; }
        public string? NameE { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public int? Aid { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        public string? Lat { get; set; }
        public string? Lng { get; set; }
        public byte? MinZoom { get; set; }
        public byte? MaxZoom { get; set; }
        public byte? CurrentZoom { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
