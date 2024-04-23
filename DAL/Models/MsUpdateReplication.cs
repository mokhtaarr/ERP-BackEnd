using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsUpdateReplication
    {
        public int UpdatId { get; set; }
        public string? TableDef { get; set; }
        public DateTime? LastUpDate { get; set; }
        public DateTime? LastUpdate2 { get; set; }
        public string? LastUpdate3 { get; set; }
    }
}
