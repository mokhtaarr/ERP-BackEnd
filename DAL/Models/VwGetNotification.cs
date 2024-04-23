using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetNotification
    {
        public int BasketId { get; set; }
        public int? UserId { get; set; }
        public int? DepartMentId { get; set; }
        public int? FromUser { get; set; }
        public string? DocName { get; set; }
        public string? DocTrNo { get; set; }
        public DateTime? TransferDate { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public DateTime? WachDate { get; set; }
        public bool? Closed { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? Message { get; set; }
        public string? Remarks { get; set; }
        public string? CurrentUser { get; set; }
        public string? SenderUser { get; set; }
        public string? UserCode { get; set; }
        public int? EmpId { get; set; }
        public byte? UserType { get; set; }
        public string? DepartCode { get; set; }
        public string? DepartName1 { get; set; }
        public string? DepartName2 { get; set; }
    }
}
