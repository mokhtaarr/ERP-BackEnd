using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchStockTransferNote
    {
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? PartFrom { get; set; }
        public int? PartTo { get; set; }
        public string? PartitionFrom { get; set; }
        public string? PartitionTo { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int TranId { get; set; }
        public int? BookId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
    }
}
