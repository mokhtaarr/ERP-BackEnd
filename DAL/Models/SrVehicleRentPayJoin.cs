using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrVehicleRentPayJoin
    {
        public int RentPayJoinId { get; set; }
        public int? VrentContractId { get; set; }
        public int? PayId { get; set; }
        public string? Remarks { get; set; }
        public int? EmpId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual MsPaymentNote? Pay { get; set; }
        public virtual SrVehicleRenalContract? VrentContract { get; set; }
    }
}
