using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaLetterQuery
    {
        public int GawabQueryId { get; set; }
        public int? LetterNormId { get; set; }
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? AuthUser { get; set; }
        public bool? IsEdit { get; set; }
        public bool? EditDone { get; set; }
        public bool? IsPrint { get; set; }
        public int? CopyCount { get; set; }
        public int? PrintedCopy { get; set; }
        public int? RemainCopy { get; set; }
        public bool? CanEditBuyer { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public int? CreatedById { get; set; }
        public int? ShiftId { get; set; }
    }
}
