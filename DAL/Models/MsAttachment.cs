using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsAttachment
    {
        public int AttachId { get; set; }
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public string? AttachType { get; set; }
        public string? AttachPath { get; set; }
        public string? AttachPath2 { get; set; }
        public string? AttachDesc1 { get; set; }
        public string? AttachDesc2 { get; set; }
        public int? AttachSerial { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? RenewalDate { get; set; }
        public string? IssuePlace { get; set; }
        public bool? Encrypted { get; set; }
        public string? EncyptionDesc { get; set; }
    }
}
