using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjReservInstallment
    {
        public int ReservInstallId { get; set; }
        public int? ReservId { get; set; }
        public int? Serial { get; set; }
        public int? InstallTempDetailId { get; set; }
        public int? PayTypeId { get; set; }
        public int? ResourceId { get; set; }
        public byte? ResourceType { get; set; }
        public int? ResourceAccountId { get; set; }
        public int? ProjUnitServiceId { get; set; }
        public int? UnitServId { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? InstallValu { get; set; }
        public decimal? PaidCash { get; set; }
        public decimal? PaidCheques { get; set; }
        public decimal? PaidBankDeposit { get; set; }
        public decimal? NotPaid { get; set; }
        public bool? IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public int? DelayDays { get; set; }
        public decimal? DelayFine { get; set; }
        public int? RectId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public bool? Deleted { get; set; }
        public string? DeletReason { get; set; }

        public virtual ProjUnitReservation? Reserv { get; set; }
    }
}
