using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class WorkForcPassPortsArchive
    {
        public int WfpassPortArchId { get; set; }
        public int WfpassPortId { get; set; }
        public int? StoreId { get; set; }
        public int? Aid { get; set; }
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
        public string? Name5en { get; set; }
        public string? Name6en { get; set; }
        public string? Name7en { get; set; }
        public string? FullNameen { get; set; }
        public int? CustomerId { get; set; }
        public int? JobId { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? PassOwnerId { get; set; }
        public int? CityId { get; set; }
        public int? SeasonId { get; set; }
        public bool? Gender { get; set; }
        /// <summary>
        /// 0 single,1 married,2 married and have kids
        /// </summary>
        public byte? MaritalStatus { get; set; }
        public byte? KidsNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? IdissueDate { get; set; }
        public DateTime? IdexpiryDate { get; set; }
        public DateTime? PassportIssueDate { get; set; }
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
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }
        public bool? Execluded { get; set; }
    }
}
