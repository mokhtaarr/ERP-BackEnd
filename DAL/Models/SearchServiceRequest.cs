using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchServiceRequest
    {
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public string? SerialNo1 { get; set; }
        public string? SerialNo2 { get; set; }
        public string? CloseReason { get; set; }
        public string? ModelNo { get; set; }
        public string? Address { get; set; }
        public decimal? QoutationPrice { get; set; }
        public DateTime? VistitDate { get; set; }
        public bool? InWarranty { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public byte? RequestStatus { get; set; }
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
        public string? CityName { get; set; }
        public string? CountryName { get; set; }
        public string? Wname1 { get; set; }
        public byte? ExemptionPercnt { get; set; }
        public string? CapcityDescA { get; set; }
        public string? Size { get; set; }
        public string? BrandName { get; set; }
        public string? ProductsTypeName { get; set; }
        public string? ReqResourceName { get; set; }
        public string? MaintenanceTypeName { get; set; }
        public string? ItemDescA { get; set; }
        public string? RegionNameA { get; set; }
        public string? Tel { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
        public string? Tel4 { get; set; }
    }
}
