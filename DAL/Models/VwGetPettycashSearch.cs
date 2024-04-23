using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwGetPettycashSearch
    {
        public string? DocTrNo { get; set; }
        public string? PrefixCode { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? Remarks { get; set; }
        public decimal? TotalPaidPrice { get; set; }
        public decimal? TotalFilteredPrice { get; set; }
        public decimal? Rate { get; set; }
        public int PettycashId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public bool? SystemIssuedOnly { get; set; }
        public byte? TermType { get; set; }
        public int? StorId { get; set; }
    }
}
