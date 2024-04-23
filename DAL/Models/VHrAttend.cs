using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VHrAttend
    {
        public int? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? Dateat { get; set; }
        public int? RolId { get; set; }
        public int? DevId { get; set; }
        public int? Mode { get; set; }
        public int Id { get; set; }
    }
}
