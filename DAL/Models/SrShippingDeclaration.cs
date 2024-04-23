using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrShippingDeclaration
    {
        public int ShipDeclarId { get; set; }
        public int? RoqId { get; set; }
        public int? Aid { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? CustomerId { get; set; }
        public int? ValidityDays { get; set; }
        public string? Shipper { get; set; }
        public string? Consignee { get; set; }
        public string? VesselName { get; set; }
        public string? PortOfLoading { get; set; }
        public string? PortOfDischarge { get; set; }
        public string? FreightPayableAt { get; set; }
        public string? BillOfLading { get; set; }
        public string? Notify { get; set; }
        public string? MarksAndNumbers { get; set; }
        public string? Remarks { get; set; }
        public string? ContainersDry { get; set; }
        public string? NetWeightTons { get; set; }
        public string? GrossWeightTons { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
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
    }
}
