using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchPassPort
    {
        public int WfpassPortId { get; set; }
        public string Code { get; set; } = null!;
        public string PassportNo { get; set; } = null!;
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Name3 { get; set; }
        public string? Name4 { get; set; }
        public string? Name5 { get; set; }
        public string? Name6 { get; set; }
        public string? Name7 { get; set; }
        public string? FullName { get; set; }
        public string? Nameen { get; set; }
        public string? Name2en { get; set; }
        public string? Name3en { get; set; }
        public string? Name4en { get; set; }
        public string? Name6en { get; set; }
        public string? Name7en { get; set; }
        public string? FullNameen { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? PassOwnerId { get; set; }
        public bool? Gender { get; set; }
        public byte? MaritalStatus { get; set; }
        public byte? KidsNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? IdissueDate { get; set; }
        public DateTime? IdexpiryDate { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string? PassportIssuePlace { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Phone3 { get; set; }
        public string? Email { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public byte? MilitaryService { get; set; }
        public string? Idmage1 { get; set; }
        public string? PassPortImage { get; set; }
        public string? Remarks { get; set; }
        public bool Execluded { get; set; }
        public string? Jcode { get; set; }
        public string? Jname1 { get; set; }
        public bool TestMandatory { get; set; }
        public string? CompCode { get; set; }
        public string? FirmName { get; set; }
        public string? FirmOwnerName { get; set; }
        public string? TaxRefNo { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public bool? IsActive { get; set; }
        public string? SeasonCode { get; set; }
        public string? SeasonName1 { get; set; }
        public string? SeasonName2 { get; set; }
        public DateTime? EmbassyDate { get; set; }
        public DateTime? AcceptAgeFrom { get; set; }
        public DateTime? AcceptAgeTo { get; set; }
        public DateTime? PassPortExpiry { get; set; }
        public string? CityCode { get; set; }
        public string? CityName { get; set; }
        public int? CustSerial { get; set; }
        public int? SeasonId { get; set; }
    }
}
