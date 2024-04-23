using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysCountry
    {
        public SysCountry()
        {
            CodCountries = new HashSet<CodCountry>();
        }

        public int CountryId { get; set; }
        public string CountryCode { get; set; } = null!;
        public string? CountryName { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }

        public virtual ICollection<CodCountry> CodCountries { get; set; }
    }
}
