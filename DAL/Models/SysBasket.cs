using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysBasket
    {
        public int BasketId { get; set; }
        public int? UserId { get; set; }
        public int? DepartMentId { get; set; }
        public int? FromUser { get; set; }
        public string? DocName { get; set; }
        public string? DocTrNo { get; set; }
        public DateTime? TransferDate { get; set; }
        public DateTime? WachDate { get; set; }
        public bool? Closed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? Message { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
    }
}
