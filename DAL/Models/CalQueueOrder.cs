using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalQueueOrder
    {
        public int OrderId { get; set; }
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public int? QueueOrder { get; set; }
    }
}
