using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsChequesOpenning
    {
        public int ChequeOpenId { get; set; }
        public bool? InOrOut { get; set; }
        public bool? IsKembiala { get; set; }
        public int? BeneficiaryAccId { get; set; }
        public bool? IsHelpingAccount { get; set; }
        public string? HelpTableName { get; set; }
        /// <summary>
        /// if Paper In [bank account and chartof account], if PaperOut [should be from book] and book is related to bank account which is related to account in chart of accounts
        /// </summary>
        public int? BoxCurrencyId { get; set; }
        public DateTime? TrDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Value { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ValueBeforeRate { get; set; }
        public string? ChequeNumber { get; set; }
        public string? Remarks { get; set; }
        public byte? CheckType { get; set; }
        public int? CustomerId { get; set; }
        public int? VendorId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }
    }
}
