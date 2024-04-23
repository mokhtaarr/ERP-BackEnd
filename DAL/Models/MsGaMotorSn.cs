using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaMotorSn
    {
        public MsGaMotorSn()
        {
            MsGaMotorSndetails = new HashSet<MsGaMotorSndetail>();
        }

        public int MotorDocId { get; set; }
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? StockRecId { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public bool? IsMotor { get; set; }
        public int? ShiftId { get; set; }
        public int? DeliverId { get; set; }

        public virtual ICollection<MsGaMotorSndetail> MsGaMotorSndetails { get; set; }
    }
}
