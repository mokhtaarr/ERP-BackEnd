using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchVehicleJobOrder
    {
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public long? StartCounter { get; set; }
        public long? EndCounter { get; set; }
        public DateTime? TimeToLeav { get; set; }
        public string? Supervisor { get; set; }
        public string? Remarks { get; set; }
        public string? Tel { get; set; }
        public string? Tel2 { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? VorderTypeCode { get; set; }
        public string? VheicleJobOrderTypeName1 { get; set; }
        public string? VehicleCode { get; set; }
        public string? VehicleName1 { get; set; }
        public string? VehicleName2 { get; set; }
        public string? RegNo { get; set; }
        public string? BodyNo { get; set; }
        public string? GarageCode { get; set; }
        public string? GarageName1 { get; set; }
        public string? GarageName2 { get; set; }
        public string? DriverCode { get; set; }
        public string? DriverName1 { get; set; }
        public string? DriverName2 { get; set; }
        public string? DriverLicense { get; set; }
        public string? LicenseDescription { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName1 { get; set; }
        public string? EmpName2 { get; set; }
        public int? BookId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int VjorderId { get; set; }
        public int? ContainersCount { get; set; }
        public string? ContainerNo { get; set; }
        public string? VehicleJobOrderName1 { get; set; }
        public string? VehicleJobOrderName2 { get; set; }
    }
}
