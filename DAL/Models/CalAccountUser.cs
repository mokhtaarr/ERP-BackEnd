using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CalAccountUser
    {
        public int AccUserId { get; set; }
        public int? AccountId { get; set; }
        public int? UserId { get; set; }
        public int? ApprovedBy { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public bool? TranAndView { get; set; }

        public virtual CalAccountChart? Account { get; set; }
        public virtual GUser? User { get; set; }
    }
}
