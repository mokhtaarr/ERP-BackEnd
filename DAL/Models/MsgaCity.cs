using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsgaCity
    {
        public MsgaCity()
        {
            SrExtensions = new HashSet<SrExtension>();
            SrHotels = new HashSet<SrHotel>();
        }

        public int CityId { get; set; }
        public string? CityCode { get; set; }
        public string? CityName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public string? Remarks { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? SysCityId { get; set; }
        public int? CountryId { get; set; }

        public virtual ICollection<SrExtension> SrExtensions { get; set; }
        public virtual ICollection<SrHotel> SrHotels { get; set; }
    }
}
