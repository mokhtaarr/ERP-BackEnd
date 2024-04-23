using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrAttendrole
    {
        public int Id { get; set; }
        public TimeSpan? Satarttimeattdend { get; set; }
        public TimeSpan? Endstarttimeattend { get; set; }
        public TimeSpan? Starttimeatdepartur { get; set; }
        public TimeSpan? Endtimeatdepartur { get; set; }
        public string? Nameshift { get; set; }
    }
}
