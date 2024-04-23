using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsMobSetting
    {
        public int MobSetId { get; set; }
        public int? UserId { get; set; }
        public byte? TermType { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? TermId { get; set; }
        public int? NotiFyUserId1 { get; set; }
        public int? NotiFyUserId2 { get; set; }
        public int? NotiFyUserId3 { get; set; }
        public int? NotiFyUserId4 { get; set; }
        public int? NotiFyUserId5 { get; set; }
    }
}
