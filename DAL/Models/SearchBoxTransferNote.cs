using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchBoxTransferNote
    {
        public string? DocTrNo { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public string? Remarks { get; set; }
        public string? StrCustm1 { get; set; }
        public string? StrCustm2 { get; set; }
        public bool? IsBox { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
    }
}
