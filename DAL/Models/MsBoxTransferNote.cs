using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsBoxTransferNote
    {
        public MsBoxTransferNote()
        {
            MsBoxTransferDetails = new HashSet<MsBoxTransferDetail>();
        }

        public int BoxTranId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public bool? IsBox { get; set; }
        public string? StrCustm1 { get; set; }
        public string? StrCustm2 { get; set; }
        public string? StrCustm3 { get; set; }
        public string? Remarks { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<MsBoxTransferDetail> MsBoxTransferDetails { get; set; }
    }
}
