using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaPeriodicBook
    {
        public MsGaPeriodicBook()
        {
            MsGaPeriodicBookDetails = new HashSet<MsGaPeriodicBookDetail>();
        }

        public int PeriodicBookId { get; set; }
        public int? StoreId { get; set; }
        public int? CapcityId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? UserId { get; set; }
        public string? Remarks { get; set; }
        public int? SerialStart { get; set; }
        public int? SerialEnd { get; set; }
        public string? FirstLetter { get; set; }
        public string? LastLetter { get; set; }
        public string? PreFix { get; set; }
        public bool? Approved { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovedBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public int? VendorId { get; set; }
        public string? ManualTrNo { get; set; }
        public bool? BodyOrMotor { get; set; }
        public string? Model { get; set; }
        public string? Logo1 { get; set; }
        public string? Logo2 { get; set; }
        public string? Logo3 { get; set; }
        public string? Cover1 { get; set; }
        public string? Cover2 { get; set; }
        public int? ShiftId { get; set; }

        public virtual ICollection<MsGaPeriodicBookDetail> MsGaPeriodicBookDetails { get; set; }
    }
}
