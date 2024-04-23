using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjUnitReservationHistory
    {
        public int PeriodIncreasId { get; set; }
        public int? ReservId { get; set; }
        public DateTime? PrevTrDateFrom { get; set; }
        public DateTime? PrevTrDateTo { get; set; }
        public DateTime? NextTrDateFrom { get; set; }
        public DateTime? NextTrDateTo { get; set; }
        public byte? ExtendType { get; set; }
        public decimal? IncreaseValue { get; set; }
        public int? ExtendPeriod { get; set; }
        public int? ExtendSubPeriod { get; set; }
        public bool? IsRental { get; set; }
    }
}
