using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsChequeTransferDetail
    {
        public int ChequTranDetailId { get; set; }
        public int? RectId { get; set; }
        public int? CustomerId { get; set; }
        public decimal? BalanceAfter { get; set; }
        public string? Remarks { get; set; }
    }
}
