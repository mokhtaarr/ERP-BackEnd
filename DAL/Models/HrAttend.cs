using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrAttend
    {
        public int Id { get; set; }
        public int? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? Dateat { get; set; }
        public TimeSpan? Timeat { get; set; }
        public int? Mode { get; set; }
        public decimal? Countleate { get; set; }
        public int? DevId { get; set; }
        public int? RolId { get; set; }
        public string? Moderol { get; set; }
        public decimal? Countearly { get; set; }
        public decimal? Countearlypure { get; set; }
        public decimal? Countovertim { get; set; }
        public int? Idatthes { get; set; }
    }
}
