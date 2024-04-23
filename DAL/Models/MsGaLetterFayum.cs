using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaLetterFayum
    {
        public MsGaLetterFayum()
        {
            MsGaLetterFayumDetails = new HashSet<MsGaLetterFayumDetail>();
            MsGaMotorSndetails = new HashSet<MsGaMotorSndetail>();
        }

        public int LetterFayumId { get; set; }
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? Client2 { get; set; }
        public string? AddField11 { get; set; }
        public string? AddField21 { get; set; }
        public int? BodyPeriodicBookId { get; set; }
        public int? MotorPeriodicBookId { get; set; }
        public bool? BookMotorPrint { get; set; }
        public bool? BookBodyPrint { get; set; }
        public bool? ApprovedBookMotor { get; set; }
        public bool? ApprovedBookBody { get; set; }
        public DateTime? BookMotorPrintTime { get; set; }
        public DateTime? BookBodyPrintTime { get; set; }
        public string? LogoPrintedMotor { get; set; }
        public string? LogoPrintedBody { get; set; }

        public virtual ICollection<MsGaLetterFayumDetail> MsGaLetterFayumDetails { get; set; }
        public virtual ICollection<MsGaMotorSndetail> MsGaMotorSndetails { get; set; }
    }
}
