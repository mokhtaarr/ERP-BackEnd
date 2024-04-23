using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchReqOfQoutation
    {
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public string? Shipper { get; set; }
        public string? PortOfLoading { get; set; }
        public string? PortOfDischarge { get; set; }
        public decimal? Commodity { get; set; }
        public decimal? Equipment { get; set; }
        public decimal? Volume { get; set; }
        public decimal? TargetRate { get; set; }
        public decimal? Recommendation { get; set; }
        public decimal? TruckingFrom { get; set; }
        public decimal? TruckingTo { get; set; }
        public string? Remarks { get; set; }
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
    }
}
