using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysCounter
    {
        public int CounterId { get; set; }
        public string? TrIdName { get; set; }
        public int? Counter { get; set; }
        public int? BookId { get; set; }
    }
}
