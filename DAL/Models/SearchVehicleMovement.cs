using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchVehicleMovement
    {
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? NetTime { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public string? Remarks { get; set; }
        public string? VendorCode { get; set; }
        public string? VendorDescA { get; set; }
        public string? VendorDescE { get; set; }
        public string? AnCode { get; set; }
        public string? AnName { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public int? StorId { get; set; }
    }
}
