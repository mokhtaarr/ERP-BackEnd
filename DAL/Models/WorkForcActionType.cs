using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcActionType
    {
        public int ActionTypeId { get; set; }
        public string? ActionCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public bool? StopPassport { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
