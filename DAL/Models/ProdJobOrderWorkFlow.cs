using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdJobOrderWorkFlow
    {
        public int JobOrderDepartId { get; set; }
        public int? JobOrderId { get; set; }
        public int? DepartMentId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? UserId { get; set; }
        public string? Note { get; set; }

        public virtual ProdJobOrder? JobOrder { get; set; }
    }
}
