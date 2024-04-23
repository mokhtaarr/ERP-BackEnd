using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrServiceRequest
    {
        public int SerReqId { get; set; }
        public int? Aid { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? CustomerId { get; set; }
        public int? ItemCardId { get; set; }
        /// <summary>
        /// 1 Good,2 Weak, Perfect 3
        /// </summary>
        public byte? ItemStatus { get; set; }
        public int? BrandId { get; set; }
        public int? ProductTypeId { get; set; }
        public int? ReqResourcId { get; set; }
        public int? MaintainTypeId { get; set; }
        public int? CapcityId { get; set; }
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        public int? Wid { get; set; }
        public string? SerialNo1 { get; set; }
        public string? SerialNo2 { get; set; }
        public string? ModelNo { get; set; }
        public string? Address { get; set; }
        public string? Complain { get; set; }
        public decimal? QoutationPrice { get; set; }
        public DateTime? VistitDate { get; set; }
        public bool? InWarranty { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        /// <summary>
        /// 1 opened,2 closed
        /// </summary>
        public byte? RequestStatus { get; set; }
        public string? CloseReason { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public string? AddField8 { get; set; }
        public string? AddField9 { get; set; }
        public string? AddField10 { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }
    }
}
