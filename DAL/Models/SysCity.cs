using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysCity
    {
        public SysCity()
        {
            CodCities = new HashSet<CodCity>();
        }

        public int SysCityId { get; set; }
        public string? CityName { get; set; }
        public string? CountryCode { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }

        public virtual ICollection<CodCity> CodCities { get; set; }
    }
}
