using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrSysgenral
    {
        public int Id { get; set; }
        public string? Modrolin { get; set; }
        public string? Modrolout { get; set; }
        public int? Countmin { get; set; }
        public int? Modes { get; set; }
        public string? Namesetting { get; set; }
        public string? Dateformat { get; set; }
        public int? Filteratt { get; set; }
        public int? Filtercheckcollector { get; set; }
    }
}
