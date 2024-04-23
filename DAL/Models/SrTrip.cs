using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrTrip
    {
        public SrTrip()
        {
            SrAccomodations = new HashSet<SrAccomodation>();
            SrExtensions = new HashSet<SrExtension>();
            SrFlights = new HashSet<SrFlight>();
            SrTransportations = new HashSet<SrTransportation>();
            SrTripProgramJoins = new HashSet<SrTripProgramJoin>();
        }

        public int TripId { get; set; }
        public int? StoreId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? CityId { get; set; }
        public int? TourGuideEmpId { get; set; }
        public int? TourLeaderEmpId { get; set; }
        public string? TourGuideName { get; set; }
        public string? TourLeaderName { get; set; }
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? DeparturDate { get; set; }
        public DateTime? DeparturTime { get; set; }
        public string? ArrivedBy { get; set; }
        public string? DepartureBy { get; set; }
        public bool? Approver { get; set; }
        public string? ApprovedBy { get; set; }
        public int? ApprovedByEmpId { get; set; }
        public string? Remarks { get; set; }
        public bool? Guid { get; set; }
        public bool? Visa { get; set; }
        public string? Others { get; set; }
        public byte? PersonsCount { get; set; }
        public string? Agent { get; set; }
        public string? Program { get; set; }
        public string? Names { get; set; }
        public string? OperatorName { get; set; }
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
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
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

        public virtual ICollection<SrAccomodation> SrAccomodations { get; set; }
        public virtual ICollection<SrExtension> SrExtensions { get; set; }
        public virtual ICollection<SrFlight> SrFlights { get; set; }
        public virtual ICollection<SrTransportation> SrTransportations { get; set; }
        public virtual ICollection<SrTripProgramJoin> SrTripProgramJoins { get; set; }
    }
}
