using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderSearch
    {
        public string SourcTyp { get; set; } = null!;
        public int? StoreId { get; set; }
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int TenderId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public byte? TenderStatus { get; set; }
        public byte? OwnerType { get; set; }
        public byte? ConsultantType { get; set; }
        public byte? SepcConsultantType { get; set; }
        public byte? PmType { get; set; }
        public bool? IsInternal { get; set; }
    }
}
