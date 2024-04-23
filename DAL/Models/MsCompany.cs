using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCompany
    {
        public int CompanyId { get; set; }
        public int? Code { get; set; }
        public string? CompShortNameA { get; set; }
        public string? CompShortNameE { get; set; }
        public string? CompNameA { get; set; }
        public string? CompNameE { get; set; }
        public string? OwnerName { get; set; }
        public string? PostalCode { get; set; }
        public int? RegionId { get; set; }
        public string? MailBox { get; set; }
        public string? Address { get; set; }
        public string? Tel1 { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
        public string? Tel4 { get; set; }
        public string? Fax1 { get; set; }
        public string? Fax2 { get; set; }
        public string? Fax3 { get; set; }
        public string? Fax4 { get; set; }
        public string? Mobile { get; set; }
        public string? Mobile1 { get; set; }
        public string? Mobile2 { get; set; }
        public string? Mobile3 { get; set; }
        public string? Email { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
        public string? Email3 { get; set; }
        public string? Website { get; set; }
        public string? Website3 { get; set; }
        public string? Website2 { get; set; }
        public string? Website1 { get; set; }
        public DateTime? DateOfEstablishment { get; set; }
        public byte[]? Logo { get; set; }
        public string? LegalEntity { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public DateTime? YearStartfrom { get; set; }
        public DateTime? YearEndTo { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
