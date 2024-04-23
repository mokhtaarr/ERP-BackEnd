using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchTrip
    {
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public string? TourGuideName { get; set; }
        public string? TourLeaderName { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? DeparturDate { get; set; }
        public DateTime? DeparturTime { get; set; }
        public string? ArrivedBy { get; set; }
        public string? DepartureBy { get; set; }
        public bool? Approver { get; set; }
        public string? ApprovedBy { get; set; }
        public bool? Guid { get; set; }
        public bool? Visa { get; set; }
        public string? Others { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Email2 { get; set; }
        public string? Email3 { get; set; }
        public string? Email4 { get; set; }
        public string? Address { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
        public string? Tel4 { get; set; }
        public string? Tel5 { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? Remarks { get; set; }
        public string? CityCode { get; set; }
        public string? CityName { get; set; }
        public byte? PersonsCount { get; set; }
        public string? Agent { get; set; }
        public string? Program { get; set; }
        public string? Names { get; set; }
        public string? OperatorName { get; set; }
        public int? BookId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
    }
}
