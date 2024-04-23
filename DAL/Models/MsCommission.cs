using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCommission
    {
        public int CommissionDocId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? EmpId { get; set; }
        public byte? CalcMethod { get; set; }
        public decimal? CommissionPercent { get; set; }
        public decimal? CommissionValue { get; set; }
        public int? FromBookId { get; set; }
        public int? ToBookId { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
    }
}
