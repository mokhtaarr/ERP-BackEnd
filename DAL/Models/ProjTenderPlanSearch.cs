using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderPlanSearch
    {
        public string SourcTyp { get; set; } = null!;
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int TenderPlanId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public string? SalesInvDocTrNo { get; set; }
    }
}
