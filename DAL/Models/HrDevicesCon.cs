using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrDevicesCon
    {
        public int Id { get; set; }
        public string? Ip { get; set; }
        public string? Port { get; set; }
        public string? Keycomm { get; set; }
        public string? Namedev { get; set; }
        public int? Moodes { get; set; }
        public int? Statuess { get; set; }
    }
}
