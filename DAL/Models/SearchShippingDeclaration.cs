using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchShippingDeclaration
    {
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public string? Shipper { get; set; }
        public string? PortOfLoading { get; set; }
        public string? PortOfDischarge { get; set; }
        public string? Consignee { get; set; }
        public string? VesselName { get; set; }
        public string? FreightPayableAt { get; set; }
        public string? BillOfLading { get; set; }
        public string? ContainersDry { get; set; }
        public string? NetWeightTons { get; set; }
        public string? GrossWeightTons { get; set; }
        public string? Remarks { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreDescA { get; set; }
        public string? StoreDescE { get; set; }
        public int? BookId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public string? AnalyticalCode { get; set; }
        public int? CodeLevel { get; set; }
        public byte? CodeLevelType { get; set; }
        public string? AnalyticalCodeName1 { get; set; }
        public string? AnalyticalCodeName2 { get; set; }
        public bool? Stopped { get; set; }
        public string? ReqOfQoutationDocTrNo { get; set; }
        public DateTime? ReqOfQoutationTrDate { get; set; }
    }
}
